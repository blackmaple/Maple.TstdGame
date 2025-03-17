
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Inventory"."Item"]
    /// [Tstd2.Manager.TagResource]=>[CloneableObject]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000208U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121], [73, 116, 101, 109])]


    // class 0x10 System.String tag
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "tag", "TAG")]

    // struct 0x18 System.Int32 id
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "id", "ID")]

    // class 0x20 System.String itemName
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "itemName", "ITEM_NAME")]

    // class 0x28 System.String desc
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "desc", "DESC")]

    // class 0x30 UnityEngine.Sprite icon
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"icon", "ICON")]

    // class 0x38 System.String iconPath
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"iconPath", "ICON_PATH")]

    // struct 0x40 System.Int32 price
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"price", "PRICE")]

    // struct 0x44 System.Boolean isCanSell
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isCanSell", "IS_CAN_SELL")]

    // enum 0x48 Tstd2.Inventory.ItemType typeID
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Inventory.ItemType),"typeID", "TYPE_ID")]

    // enum 0x4C Tstd2.Inventory.ItemQuality itemColor
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Inventory.ItemQuality),"itemColor", "ITEM_COLOR")]

    // struct 0x50 System.Single sellDiscount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"sellDiscount", "SELL_DISCOUNT")]
    public partial class Item
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Inventory";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121];

        //public const string Const_ClassName = "Item";
        //public static byte[] Static_ClassName { get; } = [73, 116, 101, 109];

        //public const uint Const_TypeToken = 0x02000208U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Item(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Item(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Item obj) => obj._ptr;
            public static implicit operator bool(Ptr_Item obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Inventory"."Item"]
    /// </summary>
    public partial class Item
    {



        /// <summary>
        ///   System.Object Clone()
        /// </summary>
        /// <returns>class System.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
        ///  extern nint CLONE ();


        /// <summary>
        ///   UnityEngine.Sprite get_Icon()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Icon")]
        ///  extern nint GET_ICON ();


        /// <summary>
        ///   System.Boolean get_IsCharacter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsCharacter")]
        ///  extern System.Boolean GET_IS_CHARACTER ();


        /// <summary>
        ///   System.Boolean get_IsEquipType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsEquipType")]
        ///  extern System.Boolean GET_IS_EQUIP_TYPE ();


        /// <summary>
        ///   System.Boolean get_isSystem()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSystem")]
        ///  extern System.Boolean GET_IS_SYSTEM ();


        /// <summary>
        ///   System.Boolean get_IsUseType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsUseType")]
        ///  extern System.Boolean GET_IS_USE_TYPE ();


        /// <summary>
        ///   System.String get_ItemName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ItemName")]
        ///  extern nint GET_ITEM_NAME ();


        /// <summary>
        /// static  System.String GetId(Tstd2.Inventory.Item item)
        /// </summary>
        /// <param name="item">class Tstd2.Inventory.Item</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetId")]
        /// static extern nint GET_ID (nint item);


        /// <summary>
        /// static  System.String GetItemColorString(Tstd2.Inventory.Item item)
        /// </summary>
        /// <param name="item">class Tstd2.Inventory.Item</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemColorString")]
        /// static extern nint GET_ITEM_COLOR_STRING (nint item);


        /// <summary>
        /// static  System.String GetName(Tstd2.Inventory.Item item)
        /// </summary>
        /// <param name="item">class Tstd2.Inventory.Item</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
        /// static extern nint GET_NAME (nint item);


        /// <summary>
        ///   System.Boolean IsCanBuy(System.Int32 money)
        /// </summary>
        /// <param name="money">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCanBuy")]
        ///  extern System.Boolean IS_CAN_BUY (System.Int32 money);


        /// <summary>
        /// static  Tstd2.Inventory.Equipment LoadEquipment(System.String _tag)
        /// </summary>
        /// <param name="_tag">class System.String</param>
        /// <returns>class Tstd2.Inventory.Equipment</returns>
        //    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadEquipment")]
        //    static extern Equipment.Ptr_Equipment LOAD_EQUIPMENT(PMonoString _tag);


        /// <summary>
        /// static  Tstd2.Inventory.Item LoadItem(System.String _tag)
        /// </summary>
        /// <param name="_tag">class System.String</param>
        /// <returns>class Tstd2.Inventory.Item</returns>
        //      [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadItem")]
        //   static extern Item.Ptr_Item LOAD_ITEM(PMonoString _tag);

        /// <summary>
        /// static  Tstd2.Inventory.Equipment LoadEquipment(System.String _tag, System.String _entrys)
        /// </summary>
        /// <param name="_tag">class System.String</param>
        /// <param name="_entrys">class System.String</param>
        /// <returns>class Tstd2.Inventory.Equipment</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadEquipment")]
        static extern Equipment.Ptr_Equipment LOAD_EQUIPMENT(PMonoString _tag, PMonoString _entrys);


        /// <summary>
        /// static  Tstd2.Inventory.Item LoadItem(System.String _tag, System.String _entrys)
        /// </summary>
        /// <param name="_tag">class System.String</param>
        /// <param name="_entrys">class System.String</param>
        /// <returns>class Tstd2.Inventory.Item</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadItem")]
        static extern Item.Ptr_Item LOAD_ITEM(PMonoString _tag, PMonoString _entrys);

        /// <summary>
        ///   System.Boolean RemoveEntry(System.String _entry)
        /// </summary>
        /// <param name="_entry">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntry")]
        ///  extern System.Boolean REMOVE_ENTRY (nint _entry);


        /// <summary>
        ///   System.Void SetEntry(System.String entrys)
        /// </summary>
        /// <param name="entrys">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEntry")]
        ///  extern void SET_ENTRY (nint entrys);


        /// <summary>
        ///   System.Void SetEntryMap(System.Collections.Generic.Dictionary<System.String,System.Int32> entrysMap)
        /// </summary>
        /// <param name="entrysMap">class System.Collections.Generic.Dictionary<System.String,System.Int32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEntryMap")]
        ///  extern void SET_ENTRY_MAP (nint entrysMap);


        /// <summary>
        ///   System.Int32 ShopPrice(System.Boolean isSell)
        /// </summary>
        /// <param name="isSell">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShopPrice")]
        ///  extern System.Int32 SHOP_PRICE (System.Boolean isSell);


        /// <summary>
        ///   System.Void UpdateCallback(System.String _entry, System.Int32 _addVal)
        /// </summary>
        /// <param name="_entry">class System.String</param>
        /// <param name="_addVal">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateCallback")]
        ///  extern void UPDATE_CALLBACK (nint _entry, System.Int32 _addVal);


        /// <summary>
        ///   System.Void UpdateEntry(System.String _entry, System.Int32 _addVal)
        /// </summary>
        /// <param name="_entry">class System.String</param>
        /// <param name="_addVal">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateEntry")]
        ///  extern void UPDATE_ENTRY (nint _entry, System.Int32 _addVal);


        /// <summary>
        ///   System.Int32 ShopPrice(System.Boolean isSell)
        /// </summary>
        /// <param name="isSell">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShopPrice")]
        ///  extern System.Int32 SHOP_PRICE (System.Boolean isSell);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Item))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Item))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Item))]
        ///  extern void .CTOR_02 ();


        /// public static partial class Search_Item
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