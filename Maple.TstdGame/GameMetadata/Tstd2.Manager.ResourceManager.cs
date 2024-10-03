
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.TstdGame
{


    /// <summary>
    /// static class ["Assembly-CSharp.dll"."Tstd2.Manager"."ResourceManager"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000192U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114], [82, 101, 115, 111, 117, 114, 99, 101, 77, 97, 110, 97, 103, 101, 114])]

    //  class static System.Collections.Generic.Dictionary<System.String,System.Object[]> _dictionary3
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_dictionary3", "_DICTIONARY3", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,Tstd2.Manager.IDResource>> _dictionary
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_dictionary", "_DICTIONARY", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.Int32,Tstd2.Manager.SerializedResource>> _dictionary2
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_dictionary2", "_DICTIONARY2", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,Tstd2.Manager.TagResource>> _dictionary4
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_OptimizationDefault<PMonoString, PMonoDictionary_OptimizationDefault<PMonoString, TagResource.Ptr_TagResource>>), "_dictionary4", "_DICTIONARY4", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,UnityEngine.AudioClip> _audioClips
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_audioClips", "_AUDIO_CLIPS", true)]

    //  class static System.Collections.Generic.Dictionary<System.String,UnityEngine.AssetBundle> localBundle
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"localBundle", "LOCAL_BUNDLE", true)]

    //  class static PacketReader packetReader
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"packetReader", "PACKET_READER", true)]

    //  class static System.Int32[] k
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"k", "K", true)]

    public partial class ResourceManager
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Manager";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114];

        //public const string Const_ClassName = "ResourceManager";
        //public static byte[] Static_ClassName { get; } = [82, 101, 115, 111, 117, 114, 99, 101, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x02000192U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ResourceManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ResourceManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ResourceManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_ResourceManager obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Manager"."ResourceManager"]
    /// </summary>
    public partial class ResourceManager
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        /// static  System.Byte[] D(System.String filePath)
        /// </summary>
        /// <param name="filePath">class System.String</param>
        /// <returns>class System.Byte[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("D")]
        /// static extern nint D (nint filePath);


        /// <summary>
        /// static  System.Byte[] DB(System.Byte[] _data)
        /// </summary>
        /// <param name="_data">class System.Byte[]</param>
        /// <returns>class System.Byte[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DB")]
        /// static extern nint DB (nint _data);


        /// <summary>
        /// static  System.Boolean ETF(System.String filePath)
        /// </summary>
        /// <param name="filePath">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ETF")]
        /// static extern System.Boolean ETF (nint filePath);


        /// <summary>
        /// static  System.Collections.Generic.List<System.String> GetFilesInDirectory(System.String path)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <returns>class System.Collections.Generic.List<System.String></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFilesInDirectory")]
        /// static extern nint GET_FILES_IN_DIRECTORY (nint path);


        /// <summary>
        /// static  System.Collections.IEnumerator InitAssetsBundle(System.String bundleName)
        /// </summary>
        /// <param name="bundleName">class System.String</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitAssetsBundle")]
        /// static extern nint INIT_ASSETS_BUNDLE (nint bundleName);


        /// <summary>
        /// static  T[] LoadAllIDResources(System.String path)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAllIDResources")]
        /// static extern nint LOAD_ALL_ID_RESOURCES (nint path);


        /// <summary>
        /// static  T[] LoadAllResources(System.String path)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAllResources")]
        /// static extern nint LOAD_ALL_RESOURCES (nint path);


        /// <summary>
        /// static  T[] LoadAllTagResources(System.String path)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAllTagResources")]
        /// static extern nint LOAD_ALL_TAG_RESOURCES (nint path);


        /// <summary>
        /// static  System.Collections.IEnumerator LoadAssetsBundle(System.String bundleName, System.Action<System.Byte[]> _callback)
        /// </summary>
        /// <param name="bundleName">class System.String</param>
        /// <param name="_callback">class System.Action<System.Byte[]></param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAssetsBundle")]
        /// static extern nint LOAD_ASSETS_BUNDLE (nint bundleName, nint _callback);


        /// <summary>
        /// static  UnityEngine.AudioClip LoadAudio(System.String name, Tstd2.Manager.AudioType audioType)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="audioType">enum Tstd2.Manager.AudioType</param>
        /// <returns>class UnityEngine.AudioClip</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadAudio")]
        /// static extern nint LOAD_AUDIO (nint name, Tstd2.Manager.AudioType audioType);


        /// <summary>
        /// static  T LoadBaseResources(System.String path, System.Int32 id)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <param name="id">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadBaseResources")]
        /// static extern nint LOAD_BASE_RESOURCES (nint path, System.Int32 id);


        /// <summary>
        /// static  UnityEngine.Texture2D LoadLocalPNG(System.String path)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadLocalPNG")]
        /// static extern nint LOAD_LOCAL_PNG (nint path);


        /// <summary>
        /// static  T LoadLocalResource(System.String path)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadLocalResource")]
        /// static extern nint LOAD_LOCAL_RESOURCE (nint path);


        /// <summary>
        /// static  T LoadSerializedResources(System.String path, System.Int32 id)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <param name="id">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadSerializedResources")]
        /// static extern nint LOAD_SERIALIZED_RESOURCES (nint path, System.Int32 id);


        /// <summary>
        /// static  System.Collections.IEnumerator LoadStory(System.String stroyName)
        /// </summary>
        /// <param name="stroyName">class System.String</param>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadStory")]
        /// static extern nint LOAD_STORY (nint stroyName);


        /// <summary>
        /// static  System.String ReadFile(System.String path)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReadFile")]
        /// static extern nint READ_FILE (nint path);



        /// <summary>
        /// static  T LoadResources(System.String path, System.String name)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <param name="name">class System.String</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadResources", Search = typeof(Search_ResourceManager))]
        /// static extern nint LOAD_RESOURCES_00 (nint path, nint name);


        /// <summary>
        /// static  T LoadResources(System.String path, System.Int32 id)
        /// </summary>
        /// <param name="path">class System.String</param>
        /// <param name="id">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadResources", Search = typeof(Search_ResourceManager))]
        /// static extern nint LOAD_RESOURCES_01 (nint path, System.Int32 id);


        /// public static partial class Search_ResourceManager
        /// {
        /// 
        ///     

        /// <summary>
        /// static  T LoadResources(System.String path, System.String name)
        /// </summary>
        /// public static bool LOAD_RESOURCES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LoadResources", "System.String", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T LoadResources(System.String path, System.Int32 id)
        /// </summary>
        /// public static bool LOAD_RESOURCES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LoadResources", "System.String", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}