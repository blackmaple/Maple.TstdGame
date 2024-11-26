using Maple.MonoGameAssistant.AndroidCore;
using Maple.MonoGameAssistant.AndroidCore.Api;
using Maple.MonoGameAssistant.AndroidCore.HostedService;
using Maple.MonoGameAssistant.AndroidJNI.Classes;
using Maple.MonoGameAssistant.AndroidJNI.Context;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Reference;
using Maple.MonoGameAssistant.AndroidJNI.JNI.Value;
using Microsoft.Extensions.Hosting;
using System.Runtime.InteropServices;
using unsafe ApiActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JINT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;
using unsafe TestActionDelegate = delegate* unmanaged<Maple.MonoGameAssistant.AndroidJNI.JNI.Value.PTR_JNI_ENV, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JOBJECT, Maple.MonoGameAssistant.AndroidJNI.JNI.Reference.JSTRING, Maple.MonoGameAssistant.AndroidJNI.JNI.Primitive.JBOOLEAN>;

namespace Maple.TstdGame.Android
{


    //public static class TstdGameAndroidExtensions
    //{


    //    [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
    //    public unsafe static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
    //    {
    //        delegate* unmanaged<PTR_JAVA_VM, JOBJECT, JINT> @delegate = &AndroidApiExtensions.JNI_OnLoad;
    //        return @delegate(javaVM, reserved);
    //    }

    //    [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload))]
    //    public unsafe static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
    //    {
    //        delegate* unmanaged<PTR_JAVA_VM, JOBJECT, void> @delegate = &AndroidApiExtensions.JNI_OnUnload;
    //        @delegate(javaVM, reserved);
    //    }

    //    [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction))]
    //    public unsafe static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
    //    {
    //        delegate* unmanaged<PTR_JNI_ENV, JOBJECT, JINT, JSTRING, JBOOLEAN> @delegate = &AndroidApiExtensions.ApiAction;
    //        return @delegate(jniEnv, instance, actionIndex, json);
    //    }

    //    [UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
    //    public unsafe static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
    //    {
    //        delegate* unmanaged<PTR_JNI_ENV, JOBJECT, JSTRING, JBOOLEAN> @delegate = &AndroidApiExtensions.TestAction;
    //        return @delegate(jniEnv, instance, text);
    //    }


    //}




    public unsafe static partial class TstdGameAndroidExtensions
    {
        public static AndroidApiContext CreateTstdGameAndroidService(this AndroidApiContext androidApiContext)
        {
            _ = Task.Factory.StartNew(AndroidServiceTask, androidApiContext, TaskCreationOptions.LongRunning);
            return androidApiContext;

            static void AndroidServiceTask(object? obj)
            {
                if (obj is not AndroidApiContext context)
                {
                    return;
                }
                Thread.Sleep(10000);
                var host = context.CreateAndroidService(p => { p.GameName = "吞食天地:刘蜀霸王"; }, p => p.AddGameContextService<TstdGameAndroidService>());
                host.Run();
            }
        }

        public const string JavaClassFullName = "com/android/maple/service/MapleService";

        static AndroidApiContext? ApiContext { get; set; }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnLoad))]
        public static JINT JNI_OnLoad(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            return JNI_OnLoadImp(javaVM, reserved);
        }
        public static JINT JNI_OnLoadImp(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            ApiContext = AndroidApiContext.CreateContext(javaVM).CreateTstdGameAndroidService();
            if (ApiContext.VirtualMachineContext.TryGetEnv(out var jniEnvironmentContext))
            {
                jniEnvironmentContext.RegisterNativeMethod(JavaClassFullName, nameof(TestAction), "(Ljava/lang/String;)Z", new Ptr_Func_TestAction(&TestAction));
                jniEnvironmentContext.RegisterNativeMethod(JavaClassFullName, nameof(ApiAction), "(ILjava/lang/String;)Z", new Ptr_Func_ApiAction(&ApiAction));
            }
            return JavaVirtualMachineContext.JNI_VERSION_1_6;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(JNI_OnUnload))]
        public static void JNI_OnUnload(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
            JNI_OnUnloadImp(javaVM, reserved);
        }
        public static void JNI_OnUnloadImp(PTR_JAVA_VM javaVM, JOBJECT reserved)
        {
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(ApiAction))]
        public static JBOOLEAN ApiAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {
            return ApiActionImp(jniEnv, instance, actionIndex, json);
        }
        public static JBOOLEAN ApiActionImp(PTR_JNI_ENV jniEnv, JOBJECT instance, JINT actionIndex, JSTRING json)
        {
            return ApiContext?.TryWrite(AndroidApiArgs.Create(jniEnv, instance, actionIndex, json)) ?? false;
        }

        [UnmanagedCallersOnly(EntryPoint = nameof(TestAction))]
        public static JBOOLEAN TestAction(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            return TestActionImp(jniEnv, instance, text);
        }
        public static JBOOLEAN TestActionImp(PTR_JNI_ENV jniEnv, JOBJECT instance, JSTRING text)
        {
            if (JniEnvironmentContext.TryCreateJniEnvironmentContext(jniEnv, out var jniEnvironmentContext))
            {
                var androidToast = AndroidToastReference.CreateReference(in jniEnvironmentContext);
                androidToast.Show(instance, jniEnvironmentContext.JNI_ENV.ConvertStringUnicode(text), false);
                return true;
            }
            return false;
        }

        readonly struct Ptr_Func_ApiAction(ApiActionDelegate ptr)
        {
            readonly ApiActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_ApiAction func) => (nint)func._ptr;
        }
        readonly struct Ptr_Func_TestAction(TestActionDelegate ptr)
        {
            readonly TestActionDelegate _ptr = ptr;
            public static implicit operator nint(Ptr_Func_TestAction func) => (nint)func._ptr;
        }



    }

}
