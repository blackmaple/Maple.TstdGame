
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maple.TstdMetadata.SecureInt;

namespace Maple.TstdMetadata
{


    /// <summary>
    /// class ["Assembly-CSharp.dll"."Tstd2.Inventory"."ItemSlot"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000209U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121], [73, 116, 101, 109, 83, 108, 111, 116])]


    // class 0x10 Tstd2.Inventory.Item item
    [MonoCollectorSearchFieldAttribute(typeof(Item.Ptr_Item), "item", "ITEM")]

    // struct 0x18 SecureInt count
    [MonoCollectorSearchFieldAttribute(typeof(Ref_SecureInt), "count", "COUNT")]
    public partial class ItemSlot
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Inventory";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121];

        //public const string Const_ClassName = "ItemSlot";
        //public static byte[] Static_ClassName { get; } = [73, 116, 101, 109, 83, 108, 111, 116];

        //public const uint Const_TypeToken = 0x02000209U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ItemSlot(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ItemSlot(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ItemSlot obj) => obj._ptr;
            public static implicit operator bool(Ptr_ItemSlot obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Inventory"."ItemSlot"]
    /// </summary>
    public partial class ItemSlot
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   System.Object Clone()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();


        /// <summary>
        /// static  Tstd2.Inventory.ItemSlot get_Unload()
        /// </summary>
        /// <returns>class Tstd2.Inventory.ItemSlot</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Unload")]
        /// static extern nint GET_UNLOAD ();


        /// <summary>
        /// static  System.String GetItemString(Tstd2.Inventory.ItemSlot itemSlot)
        /// </summary>
        /// <param name="itemSlot">class Tstd2.Inventory.ItemSlot</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemString")]
        /// static extern nint GET_ITEM_STRING (nint itemSlot);




        /// public static partial class Search_ItemSlot
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}