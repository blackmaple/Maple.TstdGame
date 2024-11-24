
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Characters"."Character"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000241U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115], [67, 104, 97, 114, 97, 99, 116, 101, 114])]

    //  class static System.Int32[] u2r
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"u2r", "U2R", true)]

    //  class static System.Int32[] u2rX
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"u2rX", "U2R_X", true)]

    // class 0x10 Tstd2.Characters.BaseCharacterData _data
      [MonoCollectorSearchFieldAttribute(typeof(BaseCharacterData.Ptr_BaseCharacterData),"_data", "_DATA")]

    // struct 0x18 System.Int32 Lv
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"Lv", "LV")]

    // class 0x20 Tstd2.Framework.StatList stat
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"stat", "STAT")]

    // class 0x28 System.Collections.Generic.List<System.String> EnemyPriorityAttackTargets
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"EnemyPriorityAttackTargets", "ENEMY_PRIORITY_ATTACK_TARGETS")]

    // class 0x30 System.Collections.Generic.List<Tstd2.Skills.Skill> Skills
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"Skills", "SKILLS")]

    // class 0x38 System.Collections.Generic.List<Tstd2.Skills.Formation> Formations
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"Formations", "FORMATIONS")]

    // struct 0x40 System.Int32 fixedDamage
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"fixedDamage", "FIXED_DAMAGE")]

    // class 0x48 Tstd2.Framework.StatList _addedStat
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_addedStat", "_ADDED_STAT")]

    // class 0x50 Tstd2.Characters.CharacterEquipment _equipments
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_equipments", "_EQUIPMENTS")]

    // class 0x58 UnityEngine.Sprite[,] _moveSprites
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_moveSprites", "_MOVE_SPRITES")]

    // class 0x60 UnityEngine.Sprite _deaSprite
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_deaSprite", "_DEA_SPRITE")]

    // class 0x68 System.Collections.Generic.List<UnityEngine.Sprite> _attackSpriets
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_attackSpriets", "_ATTACK_SPRIETS")]

    // struct 0x70 SecureInt _hp
    // [MonoCollectorSearchFieldAttribute(typeof(SecureInt),"_hp", "_HP")]

    // struct 0x78 System.Int32 _mp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_mp", "_MP")]

    // struct 0x7C SecureInt _maxHp
    // [MonoCollectorSearchFieldAttribute(typeof(SecureInt),"_maxHp", "_MAX_HP")]

    // struct 0x84 System.Int32 _maxMp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_maxMp", "_MAX_MP")]

    // enum 0x88 Tstd2.Characters.Immunity <immunityFlag>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(Tstd2.Characters.Immunity),"<immunityFlag>k__BackingField", "IMMUNITY_FLAG")]

    // class 0x90 System.Action<Tstd2.Characters.CharacterEquipment> changedEquipmentEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"changedEquipmentEvent", "CHANGED_EQUIPMENT_EVENT")]

    // class 0x98 System.Action<Tstd2.Characters.Character> statusChangedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"statusChangedEvent", "STATUS_CHANGED_EVENT")]
    public partial class Character
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Characters";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 67, 104, 97, 114, 97, 99, 116, 101, 114, 115];

        //public const string Const_ClassName = "Character";
        //public static byte[] Static_ClassName { get; } = [67, 104, 97, 114, 97, 99, 116, 101, 114];

        //public const uint Const_TypeToken = 0x02000241U;




        /// <summary>
        /// struct System.Int32 MaxItemCount "10"
        /// </summary>
        /// public const System.Int32 MAX_ITEM_COUNT=>"10";

        /// <summary>
        /// struct System.Int32 MoveWidth "2"
        /// </summary>
        /// public const System.Int32 MOVE_WIDTH=>"2";

        /// <summary>
        /// struct System.Int32 MoveHeight "4"
        /// </summary>
        /// public const System.Int32 MOVE_HEIGHT=>"4";

        /// <summary>
        /// struct System.Int32 PixelsPerUnit "32"
        /// </summary>
        /// public const System.Int32 PIXELS_PER_UNIT=>"32";

        /// <summary>
        /// struct System.Int32 MoveRectSize "32"
        /// </summary>
        /// public const System.Int32 MOVE_RECT_SIZE=>"32";

        /// <summary>
        /// struct System.Int32 MovePadding "8"
        /// </summary>
        /// public const System.Int32 MOVE_PADDING=>"8";

        /// <summary>
        /// struct System.Int32 LeftOffset "40"
        /// </summary>
        /// public const System.Int32 LEFT_OFFSET=>"40";

        /// <summary>
        /// struct System.Int32 AttackRectSize "64"
        /// </summary>
        /// public const System.Int32 ATTACK_RECT_SIZE=>"64";

        /// <summary>
        /// struct System.Int32 DeadRectSize "64"
        /// </summary>
        /// public const System.Int32 DEAD_RECT_SIZE=>"64";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Character(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Character(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Character obj) => obj._ptr;
            public static implicit operator bool(Ptr_Character obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Characters"."Character"]
    /// </summary>
    public partial class Character
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void add_changedEquipmentEvent(System.Action<Tstd2.Characters.CharacterEquipment> value)
        /// </summary>
        /// <param name="value">class System.Action<Tstd2.Characters.CharacterEquipment></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_changedEquipmentEvent")]
        ///  extern void ADD_CHANGED_EQUIPMENT_EVENT (nint value);


        /// <summary>
        ///   System.Void add_statusChangedEvent(System.Action<Tstd2.Characters.Character> value)
        /// </summary>
        /// <param name="value">class System.Action<Tstd2.Characters.Character></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_statusChangedEvent")]
        ///  extern void ADD_STATUS_CHANGED_EVENT (nint value);


        /// <summary>
        ///   Tstd2.Inventory.Equipment ChangeEquipment(Tstd2.Inventory.Equipment equipItem)
        /// </summary>
        /// <param name="equipItem">class Tstd2.Inventory.Equipment</param>
        /// <returns>class Tstd2.Inventory.Equipment</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ChangeEquipment")]
        ///  extern nint CHANGE_EQUIPMENT (nint equipItem);


        /// <summary>
        ///   System.Int32 get_Atk()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Atk")]
        ///  extern System.Int32 GET_ATK ();


        /// <summary>
        ///   System.Int32 get_AttackDodge()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackDodge")]
        ///  extern System.Int32 GET_ATTACK_DODGE ();


        /// <summary>
        ///   System.Collections.Generic.List<UnityEngine.Sprite> get_AttackSprites()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<UnityEngine.Sprite></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackSprites")]
        ///  extern nint GET_ATTACK_SPRITES ();


        /// <summary>
        ///   System.Int32 get_AttackTimes()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackTimes")]
        ///  extern System.Int32 GET_ATTACK_TIMES ();


        /// <summary>
        ///   UnityEngine.Sprite get_BattleAnotherReadySprite()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BattleAnotherReadySprite")]
        ///  extern nint GET_BATTLE_ANOTHER_READY_SPRITE ();


        /// <summary>
        ///   UnityEngine.Sprite get_BattleReadySprite()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BattleReadySprite")]
        ///  extern nint GET_BATTLE_READY_SPRITE ();


        /// <summary>
        ///   UnityEngine.Sprite get_BattleWithDrawnSprite()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BattleWithDrawnSprite")]
        ///  extern nint GET_BATTLE_WITH_DRAWN_SPRITE ();


        /// <summary>
        ///   Tstd2.Characters.BaseCharacterData get_CharacterData()
        /// </summary>
        /// <returns>class Tstd2.Characters.BaseCharacterData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CharacterData")]
        ///  extern nint GET_CHARACTER_DATA ();


        /// <summary>
        ///   System.Single get_CritPower()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CritPower")]
        ///  extern System.Single GET_CRIT_POWER ();


        /// <summary>
        ///   System.Int32 get_CritRate()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CritRate")]
        ///  extern System.Int32 GET_CRIT_RATE ();


        /// <summary>
        ///   UnityEngine.Sprite get_DeadSprite()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DeadSprite")]
        ///  extern nint GET_DEAD_SPRITE ();


        /// <summary>
        ///   System.Int32 get_Def()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Def")]
        ///  extern System.Int32 GET_DEF ();


        /// <summary>
        ///   Tstd2.Characters.CharacterEquipment get_Equipments()
        /// </summary>
        /// <returns>class Tstd2.Characters.CharacterEquipment</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Equipments")]
        ///  extern nint GET_EQUIPMENTS ();


        /// <summary>
        ///   System.Int32 get_HitRate()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HitRate")]
        ///  extern System.Int32 GET_HIT_RATE ();


        /// <summary>
        ///   System.Int32 get_Hp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Hp")]
        ///  extern System.Int32 GET_HP ();


        /// <summary>
        ///   System.Single get_HpRatio()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HpRatio")]
        ///  extern System.Single GET_HP_RATIO ();


        /// <summary>
        ///   System.String get_Id()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Id")]
        ///  extern nint GET_ID ();


        /// <summary>
        ///   Tstd2.Characters.Immunity get_immunityFlag()
        /// </summary>
        /// <returns>enum Tstd2.Characters.Immunity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_immunityFlag")]
        ///  extern Tstd2.Characters.Immunity GET_IMMUNITY_FLAG ();


        /// <summary>
        ///   System.Boolean get_IsDead()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsDead")]
        ///  extern System.Boolean GET_IS_DEAD ();


        /// <summary>
        ///   System.Boolean get_IsRewardCharacter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsRewardCharacter")]
        ///  extern System.Boolean GET_IS_REWARD_CHARACTER ();


        /// <summary>
        ///   System.Int32 get_Ler()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Ler")]
        ///  extern System.Int32 GET_LER ();


        /// <summary>
        ///   System.Int32 get_MaxHp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MaxHp")]
        ///  extern System.Int32 GET_MAX_HP ();


        /// <summary>
        ///   System.Int32 get_MaxMp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MaxMp")]
        ///  extern System.Int32 GET_MAX_MP ();


        /// <summary>
        ///   UnityEngine.Texture2D get_ModelTexture()
        /// </summary>
        /// <returns>class UnityEngine.Texture2D</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ModelTexture")]
        ///  extern nint GET_MODEL_TEXTURE ();


        /// <summary>
        ///   UnityEngine.Sprite[,] get_MoveSprites()
        /// </summary>
        /// <returns>class UnityEngine.Sprite[,]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MoveSprites")]
        ///  extern nint GET_MOVE_SPRITES ();


        /// <summary>
        ///   System.Int32 get_Mp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Mp")]
        ///  extern System.Int32 GET_MP ();


        /// <summary>
        ///   System.String get_Name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Name")]
        ///  extern nint GET_NAME ();


        /// <summary>
        ///   Tstd2.Skills.CommanderSkill get_PlayerCommanderSkill()
        /// </summary>
        /// <returns>class Tstd2.Skills.CommanderSkill</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerCommanderSkill")]
        ///  extern nint GET_PLAYER_COMMANDER_SKILL ();


        /// <summary>
        ///   UnityEngine.Sprite get_Profile()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Profile")]
        ///  extern nint GET_PROFILE ();


        /// <summary>
        ///   System.Int32 get_SkillAtkAdd()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SkillAtkAdd")]
        ///  extern System.Int32 GET_SKILL_ATK_ADD ();


        /// <summary>
        ///   System.Int32 get_SkillCritRate()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SkillCritRate")]
        ///  extern System.Int32 GET_SKILL_CRIT_RATE ();


        /// <summary>
        ///   System.Int32 get_SkillDef()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SkillDef")]
        ///  extern System.Int32 GET_SKILL_DEF ();


        /// <summary>
        ///   System.Int32 get_Spd()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Spd")]
        ///  extern System.Int32 GET_SPD ();


        /// <summary>
        ///   Tstd2.Battle.Buffs.GeneralBuff get_Spec()
        /// </summary>
        /// <returns>class Tstd2.Battle.Buffs.GeneralBuff</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Spec")]
        ///  extern nint GET_SPEC ();


        /// <summary>
        ///   System.Int32 get_Str()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Str")]
        ///  extern System.Int32 GET_STR ();


        /// <summary>
        ///   System.String get_StyleName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_StyleName")]
        ///  extern nint GET_STYLE_NAME ();


        /// <summary>
        ///   System.String get_TerrainNames()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TerrainNames")]
        ///  extern nint GET_TERRAIN_NAMES ();


        /// <summary>
        ///   Tstd2.Framework.TerrainType get_TerrainTypes()
        /// </summary>
        /// <returns>enum Tstd2.Framework.TerrainType</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TerrainTypes")]
        ///  extern Tstd2.Framework.TerrainType GET_TERRAIN_TYPES ();


        /// <summary>
        ///   System.String get_WeaponNames()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WeaponNames")]
        ///  extern nint GET_WEAPON_NAMES ();


        /// <summary>
        ///   Tstd2.Inventory.WeaponType get_WeaponTypes()
        /// </summary>
        /// <returns>enum Tstd2.Inventory.WeaponType</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WeaponTypes")]
        ///  extern Tstd2.Inventory.WeaponType GET_WEAPON_TYPES ();


        /// <summary>
        ///   Tstd2.Settings.HpLevelData GetHpLevelData()
        /// </summary>
        /// <returns>class Tstd2.Settings.HpLevelData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHpLevelData")]
        ///  extern nint GET_HP_LEVEL_DATA ();


        /// <summary>
        ///   System.Boolean HasTerrainFlag(Tstd2.Framework.TerrainType terrainType)
        /// </summary>
        /// <param name="terrainType">enum Tstd2.Framework.TerrainType</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasTerrainFlag")]
        ///  extern System.Boolean HAS_TERRAIN_FLAG (Tstd2.Framework.TerrainType terrainType);


        /// <summary>
        ///   System.Int32 Heal(System.Int32 hp, System.Boolean resurrect)
        /// </summary>
        /// <param name="hp">struct System.Int32</param>
        /// <param name="resurrect">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Heal")]
        ///  extern System.Int32 HEAL (System.Int32 hp, System.Boolean resurrect);


        /// <summary>
        ///   System.Boolean IsCanLearn(System.Int32 skillID)
        /// </summary>
        /// <param name="skillID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCanLearn")]
        ///  extern System.Boolean IS_CAN_LEARN (System.Int32 skillID);


        /// <summary>
        ///   System.Boolean IsEquipmentCanEquip(Tstd2.Inventory.Equipment value)
        /// </summary>
        /// <param name="value">class Tstd2.Inventory.Equipment</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEquipmentCanEquip")]
        ///  extern System.Boolean IS_EQUIPMENT_CAN_EQUIP (nint value);


        /// <summary>
        ///   System.Boolean IsWeaponCanEquip(Tstd2.Inventory.Equipment value)
        /// </summary>
        /// <param name="value">class Tstd2.Inventory.Equipment</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsWeaponCanEquip")]
        ///  extern System.Boolean IS_WEAPON_CAN_EQUIP (nint value);


        /// <summary>
        ///   System.Boolean IsWeaponType(Tstd2.Inventory.WeaponType weaponType)
        /// </summary>
        /// <param name="weaponType">enum Tstd2.Inventory.WeaponType</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsWeaponType")]
        ///  extern System.Boolean IS_WEAPON_TYPE (Tstd2.Inventory.WeaponType weaponType);


        /// <summary>
        ///   System.Void LevelUp(System.Int32 lv)
        /// </summary>
        /// <param name="lv">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LevelUp")]
        ///  extern void LEVEL_UP (System.Int32 lv);


        /// <summary>
        /// static  System.Void LoadEnemyCharacter(Tstd2.Characters.Character _char, Tstd2.Characters.BattleCharacterData characterData)
        /// </summary>
        /// <param name="_char">class Tstd2.Characters.Character</param>
        /// <param name="characterData">class Tstd2.Characters.BattleCharacterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadEnemyCharacter")]
        /// static extern void LOAD_ENEMY_CHARACTER (nint _char, nint characterData);


        /// <summary>
        /// static  Tstd2.Characters.Character LoadPlayerCharacter(System.String id)
        /// </summary>
        /// <param name="id">class System.String</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadPlayerCharacter")]
        static extern Character.Ptr_Character LOAD_PLAYER_CHARACTER(PMonoString id);


        /// <summary>
        ///   System.Int32 OriginState(Tstd2.Framework.StatType type, System.Int32 defaultValue)
        /// </summary>
        /// <param name="type">enum Tstd2.Framework.StatType</param>
        /// <param name="defaultValue">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OriginState")]
        ///  extern System.Int32 ORIGIN_STATE (Tstd2.Framework.StatType type, System.Int32 defaultValue);


        /// <summary>
        ///   System.Void remove_changedEquipmentEvent(System.Action<Tstd2.Characters.CharacterEquipment> value)
        /// </summary>
        /// <param name="value">class System.Action<Tstd2.Characters.CharacterEquipment></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_changedEquipmentEvent")]
        ///  extern void REMOVE_CHANGED_EQUIPMENT_EVENT (nint value);


        /// <summary>
        ///   System.Void remove_statusChangedEvent(System.Action<Tstd2.Characters.Character> value)
        /// </summary>
        /// <param name="value">class System.Action<Tstd2.Characters.Character></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_statusChangedEvent")]
        ///  extern void REMOVE_STATUS_CHANGED_EVENT (nint value);


        /// <summary>
        ///   System.Void set_Equipments(Tstd2.Characters.CharacterEquipment value)
        /// </summary>
        /// <param name="value">class Tstd2.Characters.CharacterEquipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Equipments")]
        ///  extern void SET_EQUIPMENTS (nint value);


        /// <summary>
        ///   System.Void set_Hp(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Hp")]
        ///  extern void SET_HP (System.Int32 value);


        /// <summary>
        ///   System.Void set_immunityFlag(Tstd2.Characters.Immunity value)
        /// </summary>
        /// <param name="value">enum Tstd2.Characters.Immunity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_immunityFlag")]
        ///  extern void SET_IMMUNITY_FLAG (Tstd2.Characters.Immunity value);


        /// <summary>
        ///   System.Void set_MaxHp(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MaxHp")]
        ///  extern void SET_MAX_HP (System.Int32 value);


        /// <summary>
        ///   System.Void set_MaxMp(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MaxMp")]
        ///  extern void SET_MAX_MP (System.Int32 value);


        /// <summary>
        ///   System.Void set_Mp(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Mp")]
        ///  extern void SET_MP (System.Int32 value);


        /// <summary>
        ///   System.Void SetAddedStatValue(Tstd2.Framework.StatType type, System.Int32 value)
        /// </summary>
        /// <param name="type">enum Tstd2.Framework.StatType</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetAddedStatValue")]
        ///  extern void SET_ADDED_STAT_VALUE (Tstd2.Framework.StatType type, System.Int32 value);



        /// <summary>
        ///   System.Void .ctor(Tstd2.Characters.BattleCharacterData data)
        /// </summary>
        /// <param name="data">class Tstd2.Characters.BattleCharacterData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Character))]
        ///  extern void .CTOR_00 (nint data);


        /// <summary>
        ///   System.Void .ctor(System.String dataID)
        /// </summary>
        /// <param name="dataID">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Character))]
        ///  extern void .CTOR_01 (nint dataID);


        /// <summary>
        ///   System.Void .ctor(Tstd2.Characters.CharacterData data, Tstd2.Characters.CharacterEquipment equip)
        /// </summary>
        /// <param name="data">class Tstd2.Characters.CharacterData</param>
        /// <param name="equip">class Tstd2.Characters.CharacterEquipment</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Character))]
        ///  extern void .CTOR_02 (nint data, nint equip);


        /// <summary>
        /// static  Tstd2.Characters.Character Init(System.String id, System.Int32 lv, System.Boolean heal)
        /// </summary>
        /// <param name="id">class System.String</param>
        /// <param name="lv">struct System.Int32</param>
        /// <param name="heal">struct System.Boolean</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_Character))]
        /// static extern nint INIT_00 (nint id, System.Int32 lv, System.Boolean heal);


        /// <summary>
        /// static  Tstd2.Characters.Character Init(Tstd2.Characters.Character character, System.Int32 lv, System.Boolean heal)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="lv">struct System.Int32</param>
        /// <param name="heal">struct System.Boolean</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init", Search = typeof(Search_Character))]
        /// static extern nint INIT_01 (nint character, System.Int32 lv, System.Boolean heal);


        /// <summary>
        ///   System.Void SetModelColor(UnityEngine.Renderer renderer)
        /// </summary>
        /// <param name="renderer">class UnityEngine.Renderer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetModelColor", Search = typeof(Search_Character))]
        ///  extern void SET_MODEL_COLOR_00 (nint renderer);


        /// <summary>
        ///   System.Void SetModelColor(UnityEngine.Material material)
        /// </summary>
        /// <param name="material">class UnityEngine.Material</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetModelColor", Search = typeof(Search_Character))]
        ///  extern void SET_MODEL_COLOR_01 (nint material);


        /// public static partial class Search_Character
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(Tstd2.Characters.BattleCharacterData data)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Tstd2.Characters.BattleCharacterData");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.String dataID)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(Tstd2.Characters.CharacterData data, Tstd2.Characters.CharacterEquipment equip)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Tstd2.Characters.CharacterData", "Tstd2.Characters.CharacterEquipment");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Tstd2.Characters.Character Init(System.String id, System.Int32 lv, System.Boolean heal)
        /// </summary>
        /// public static bool INIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init", "System.String", "System.Int32", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Tstd2.Characters.Character Init(Tstd2.Characters.Character character, System.Int32 lv, System.Boolean heal)
        /// </summary>
        /// public static bool INIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Init", "Tstd2.Characters.Character", "System.Int32", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetModelColor(UnityEngine.Renderer renderer)
        /// </summary>
        /// public static bool SET_MODEL_COLOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetModelColor", "UnityEngine.Renderer");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetModelColor(UnityEngine.Material material)
        /// </summary>
        /// public static bool SET_MODEL_COLOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetModelColor", "UnityEngine.Material");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}