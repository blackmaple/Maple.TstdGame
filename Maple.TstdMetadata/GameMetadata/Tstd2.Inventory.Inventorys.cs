
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Inventory"."Inventorys"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000203U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121], [73, 110, 118, 101, 110, 116, 111, 114, 121, 115])]
    
                
    // class 0x10 System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> slots
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"slots", "SLOTS")]
            
    // class 0x18 System.Collections.Generic.List<Tstd2.Framework.ItemSlotSaveData> TNGetSlots
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"TNGetSlots", "TN_GET_SLOTS")]
            
    // class 0x20 System.Action<Tstd2.Inventory.Inventorys> changedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"changedEvent", "CHANGED_EVENT")]
    public partial class Inventorys
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Inventory";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 73, 110, 118, 101, 110, 116, 111, 114, 121];

        //public const string Const_ClassName = "Inventorys";
        //public static byte[] Static_ClassName { get; } = [73, 110, 118, 101, 110, 116, 111, 114, 121, 115];

        //public const uint Const_TypeToken = 0x02000203U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Inventorys(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Inventorys(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Inventorys obj) => obj._ptr;
            public static implicit operator bool(Ptr_Inventorys obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll"."Tstd2.Inventory"."Inventorys"]
        /// </summary>
        public partial class Inventorys
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   System.Void add_changedEvent(System.Action<Tstd2.Inventory.Inventorys> value)
            /// </summary>
            /// <param name="value">class System.Action<Tstd2.Inventory.Inventorys></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_changedEvent")]
            ///  extern void ADD_CHANGED_EVENT (nint value);

            
            /// <summary>
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clone")]
            ///  extern nint CLONE ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_Equipments()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Equipments")]
            ///  extern nint GET_EQUIPMENTS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_ItemMaterail()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ItemMaterail")]
            ///  extern nint GET_ITEM_MATERAIL ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_Items()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Items")]
            ///  extern nint GET_ITEMS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_ItemsCanSell()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ItemsCanSell")]
            ///  extern nint GET_ITEMS_CAN_SELL ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_ItemsInBattleUse()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ItemsInBattleUse")]
            ///  extern nint GET_ITEMS_IN_BATTLE_USE ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_ItemsInNormalUse()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ItemsInNormalUse")]
            ///  extern nint GET_ITEMS_IN_NORMAL_USE ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_ItemsSystem()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ItemsSystem")]
            ///  extern nint GET_ITEMS_SYSTEM ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> get_Slots()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Slots")]
            ///  extern nint GET_SLOTS ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Tstd2.Inventory.ItemSlot> GetCharacterEquipment(System.Int32 slotType, Tstd2.Characters.Character character)
            /// </summary>
            /// <param name="slotType">struct System.Int32</param>
            /// <param name="character">class Tstd2.Characters.Character</param>
            /// <returns>class System.Collections.Generic.List<Tstd2.Inventory.ItemSlot></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCharacterEquipment")]
            ///  extern nint GET_CHARACTER_EQUIPMENT (System.Int32 slotType, nint character);

            
            /// <summary>
            ///   System.Void Increase(Tstd2.Inventory.Item item, System.Int32 count)
            /// </summary>
            /// <param name="item">class Tstd2.Inventory.Item</param>
            /// <param name="count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Increase")]
            ///  extern void INCREASE (nint item, System.Int32 count);

            
            /// <summary>
            ///   System.Int32 ItemCount(Tstd2.Inventory.Item item)
            /// </summary>
            /// <param name="item">class Tstd2.Inventory.Item</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ItemCount")]
            ///  extern System.Int32 ITEM_COUNT (nint item);

            
            /// <summary>
            ///   System.Void Remove(Tstd2.Inventory.ItemSlot itemSlot)
            /// </summary>
            /// <param name="itemSlot">class Tstd2.Inventory.ItemSlot</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
            ///  extern void REMOVE (nint itemSlot);

            
            /// <summary>
            ///   System.Void remove_changedEvent(System.Action<Tstd2.Inventory.Inventorys> value)
            /// </summary>
            /// <param name="value">class System.Action<Tstd2.Inventory.Inventorys></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_changedEvent")]
            ///  extern void REMOVE_CHANGED_EVENT (nint value);

            
            /// <summary>
            ///   System.Void RemoveItem(Tstd2.Inventory.Item item)
            /// </summary>
            /// <param name="item">class Tstd2.Inventory.Item</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItem")]
            ///  extern void REMOVE_ITEM (nint item);
            
            
            
            /// <summary>
            ///   System.Boolean Decrease(Tstd2.Inventory.Item item, System.Int32 count)
            /// </summary>
            /// <param name="item">class Tstd2.Inventory.Item</param>
            /// <param name="count">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrease", Search = typeof(Search_Inventorys))]
            ///  extern System.Boolean DECREASE_00 (nint item, System.Int32 count);

            
            /// <summary>
            ///   System.Void Decrease(Tstd2.Inventory.ItemSlot itemSlot, System.Int32 count)
            /// </summary>
            /// <param name="itemSlot">class Tstd2.Inventory.ItemSlot</param>
            /// <param name="count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrease", Search = typeof(Search_Inventorys))]
            ///  extern void DECREASE_01 (nint itemSlot, System.Int32 count);

            
            /// <summary>
            ///   Tstd2.Inventory.ItemSlot FindSlot(System.String id)
            /// </summary>
            /// <param name="id">class System.String</param>
            /// <returns>class Tstd2.Inventory.ItemSlot</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindSlot", Search = typeof(Search_Inventorys))]
            ///  extern nint FIND_SLOT_00 (nint id);

            
            /// <summary>
            ///   Tstd2.Inventory.ItemSlot FindSlot(Tstd2.Inventory.Item item)
            /// </summary>
            /// <param name="item">class Tstd2.Inventory.Item</param>
            /// <returns>class Tstd2.Inventory.ItemSlot</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindSlot", Search = typeof(Search_Inventorys))]
            ///  extern nint FIND_SLOT_01 (nint item);

            
            /// public static partial class Search_Inventorys
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Boolean Decrease(Tstd2.Inventory.Item item, System.Int32 count)
                    /// </summary>
                    /// public static bool DECREASE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrease", "Tstd2.Inventory.Item", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Decrease(Tstd2.Inventory.ItemSlot itemSlot, System.Int32 count)
                    /// </summary>
                    /// public static bool DECREASE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Decrease", "Tstd2.Inventory.ItemSlot", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Tstd2.Inventory.ItemSlot FindSlot(System.String id)
                    /// </summary>
                    /// public static bool FIND_SLOT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindSlot", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Tstd2.Inventory.ItemSlot FindSlot(Tstd2.Inventory.Item item)
                    /// </summary>
                    /// public static bool FIND_SLOT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindSlot", "Tstd2.Inventory.Item");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}