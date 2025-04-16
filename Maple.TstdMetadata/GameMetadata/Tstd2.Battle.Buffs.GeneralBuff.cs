
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.TstdMetadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Tstd2.Battle.Buffs"."GeneralBuff"]
    /// [Tstd2.Manager.TagResource]=>[CloneableObject]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000357U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 66, 117, 102, 102, 115], [71, 101, 110, 101, 114, 97, 108, 66, 117, 102, 102])]


    // class 0x10 System.String tag
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "tag", "TAG")]

    // class 0x18 System.String desc
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "desc", "DESC")]

    // class 0x20 System.Collections.Generic.List<Tstd2.Battle.Buffs.GeneralBuffData> buffData
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_D<GeneralBuffData.Ptr_GeneralBuffData>), "buffData", "BUFF_DATA")]
    public partial class GeneralBuff
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Battle.Buffs";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 66, 97, 116, 116, 108, 101, 46, 66, 117, 102, 102, 115];

        //public const string Const_ClassName = "GeneralBuff";
        //public static byte[] Static_ClassName { get; } = [71, 101, 110, 101, 114, 97, 108, 66, 117, 102, 102];

        //public const uint Const_TypeToken = 0x02000357U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GeneralBuff(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GeneralBuff(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GeneralBuff obj) => obj._ptr;
            public static implicit operator bool(Ptr_GeneralBuff obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Battle.Buffs"."GeneralBuff"]
    /// </summary>
    public partial class GeneralBuff
    {



        /// <summary>
        ///   System.Object Clone()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GeneralBuff))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GeneralBuff))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GeneralBuff))]
        ///  extern void .CTOR_02 ();


        /// public static partial class Search_GeneralBuff
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}