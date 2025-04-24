
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
    /// class ["Assembly-CSharp.dll"."Tstd2.Manager"."TeamManager"]
    /// [Tstd2.Framework.SingleInstance<Tstd2.Manager.TeamManager>]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020001B5U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114], [84, 101, 97, 109, 77, 97, 110, 97, 103, 101, 114])]

    //  struct static UnityEngine.Color FamiliarWithTerrainHpBarColor
    //  [MonoCollectorSearchFieldAttribute(typeof(UnityEngine.Color),"FamiliarWithTerrainHpBarColor", "FAMILIAR_WITH_TERRAIN_HP_BAR_COLOR", true)]

    //  class static Tstd2.Manager.TeamManager Instance
    [MonoCollectorSearchFieldAttribute(typeof(TeamManager.Ptr_TeamManager), "Instance", "INSTANCE", true)]

    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT", true)]

    // struct 0x10 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]

    // struct 0x18 System.Int32 maxPlayerMoveCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxPlayerMoveCount", "MAX_PLAYER_MOVE_COUNT")]

    // struct 0x1C System.Int32 maxNpcMoveCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxNpcMoveCount", "MAX_NPC_MOVE_COUNT")]

    // struct 0x20 System.Int32 maxJoinBattleCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxJoinBattleCount", "MAX_JOIN_BATTLE_COUNT")]

    // struct 0x24 System.Int32 maxJoinCharactersCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"maxJoinCharactersCount", "MAX_JOIN_CHARACTERS_COUNT")]

    // class 0x28 Tstd2.Skills.Formation defaultFormation
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"defaultFormation", "DEFAULT_FORMATION")]

    // struct 0x30 System.Int32 defaultMp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"defaultMp", "DEFAULT_MP")]

    // class 0x38 System.Collections.Generic.List<Tstd2.Characters.Character> characters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_D<Character.Ptr_Character>), "characters", "CHARACTERS")]

    // class 0x40 System.Collections.Generic.List<Tstd2.Characters.Character> npcCharacters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_D<Character.Ptr_Character>), "npcCharacters", "NPC_CHARACTERS")]

    // class 0x48 System.Collections.Generic.List<Tstd2.Characters.Character> alternateCharacters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_D<Character.Ptr_Character>), "alternateCharacters", "ALTERNATE_CHARACTERS")]

    // class 0x50 System.Collections.Generic.List<Tstd2.Characters.Character> tempCharacters
    [MonoCollectorSearchFieldAttribute(typeof(PMonoList_D<Character.Ptr_Character>), "tempCharacters", "TEMP_CHARACTERS")]

    // struct 0x58 SecureInt Lv
    [MonoCollectorSearchFieldAttribute(typeof(SecureInt.Ptr_SecureInt), "_lv", "LV")]

    // class 0x60 Tstd2.Inventory.Inventorys inventory
    [MonoCollectorSearchFieldAttribute(typeof(Inventorys.Ptr_Inventorys), "inventory", "INVENTORY")]

    // class 0x68 Tstd2.Characters.Character _adviser
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_adviser", "_ADVISER")]

    // class 0x70 System.Collections.Generic.List<Tstd2.Skills.Skill> _skills
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_skills", "_SKILLS")]

    // class 0x78 System.Collections.Generic.List<Tstd2.Skills.Formation> _formations
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_formations", "_FORMATIONS")]

    // struct 0x80 SecureInt _money
    // [MonoCollectorSearchFieldAttribute(typeof(SecureInt),"_money", "_MONEY")]

    // struct 0x88 SecureInt _exp
    // [MonoCollectorSearchFieldAttribute(typeof(SecureInt),"_exp", "_EXP")]

    // struct 0x90 SecureInt _mp
    // [MonoCollectorSearchFieldAttribute(typeof(SecureInt),"_mp", "_MP")]

    // struct 0x98 SecureInt _maxMp
    // [MonoCollectorSearchFieldAttribute(typeof(SecureInt),"_maxMp", "_MAX_MP")]

    // class 0xA0 Tstd2.Skills.Formation _currentFormation
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_currentFormation", "_CURRENT_FORMATION")]

    // struct 0xA8 System.Int32 goodEvilValue
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"goodEvilValue", "GOOD_EVIL_VALUE")]

    // class 0xB0 System.Collections.Generic.List<System.String> unlockAchievements
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"unlockAchievements", "UNLOCK_ACHIEVEMENTS")]

    // class 0xB8 System.String equipmentAchievement
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"equipmentAchievement", "EQUIPMENT_ACHIEVEMENT")]

    // struct 0xC0 System.Int32 NextExp
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"NextExp", "NEXT_EXP")]

    // class 0xC8 Tstd2.Settings.ExpData ExpData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"ExpData", "EXP_DATA")]

    // struct 0xD0 System.Boolean _isTestConfig
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"_isTestConfig", "_IS_TEST_CONFIG")]

    // class 0xD8 System.Collections.Generic.Dictionary<System.String,System.Int32> _events
    [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_OptimizationDefault<PMonoString, int>), "_events", "_EVENTS")]

    // struct 0xE0 System.Int32 AvoidEnemySteps
    [MonoCollectorSearchFieldAttribute(typeof(System.Int32), "AvoidEnemySteps", "AVOID_ENEMY_STEPS", IsReadOnly = false)]

    // struct 0xE4 System.Int32 AntivirusSteps
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"AntivirusSteps", "ANTIVIRUS_STEPS")]

    // struct 0xE8 System.Single <MpRatio>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"<MpRatio>k__BackingField", "MP_RATIO")]

    // class 0xF0 System.Action<Tstd2.Manager.TeamManager> CharactersChangedEvent
    [MonoCollectorSearchFieldAttribute(typeof(nint), "CharactersChangedEvent", "CHARACTERS_CHANGED_EVENT")]
    public partial class TeamManager
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "Tstd2.Manager";
        //public static byte[] Static_Namespace { get; } = [84, 115, 116, 100, 50, 46, 77, 97, 110, 97, 103, 101, 114];

        //public const string Const_ClassName = "TeamManager";
        //public static byte[] Static_ClassName { get; } = [84, 101, 97, 109, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x020001B5U;




        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";

        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_TeamManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_TeamManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_TeamManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_TeamManager obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll"."Tstd2.Manager"."TeamManager"]
    /// </summary>
    public partial class TeamManager
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   Tstd2.Characters.Character <GameStart>b__135_0(System.String v)
        /// </summary>
        /// <param name="v">class System.String</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<GameStart>b__135_0")]
        ///  extern nint <GAME_START>B__135_0 (nint v);


        /// <summary>
        ///   Tstd2.Characters.Character <GameStart>b__135_1(System.String v)
        /// </summary>
        /// <param name="v">class System.String</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<GameStart>b__135_1")]
        ///  extern nint <GAME_START>B__135_1 (nint v);


        /// <summary>
        ///   Tstd2.Characters.Character <GameStart>b__135_2(System.String v)
        /// </summary>
        /// <param name="v">class System.String</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<GameStart>b__135_2")]
        ///  extern nint <GAME_START>B__135_2 (nint v);


        /// <summary>
        ///   System.Void <GameStart>b__135_3(Tstd2.Characters.Character ch)
        /// </summary>
        /// <param name="ch">class Tstd2.Characters.Character</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<GameStart>b__135_3")]
        ///  extern void <GAME_START>B__135_3 (nint ch);


        /// <summary>
        ///   System.Void <GameStart>b__135_4(System.String e)
        /// </summary>
        /// <param name="e">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<GameStart>b__135_4")]
        ///  extern void <GAME_START>B__135_4 (nint e);


        /// <summary>
        ///   System.Boolean <get_AdviserIndex>b__50_0(Tstd2.Characters.Character ch)
        /// </summary>
        /// <param name="ch">class Tstd2.Characters.Character</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<get_AdviserIndex>b__50_0")]
        ///  extern System.Boolean <GET_ADVISER_INDEX>B__50_0 (nint ch);


        /// <summary>
        ///   System.Void <InitEvents>b__109_0(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<InitEvents>b__109_0")]
        ///  extern void <INIT_EVENTS>B__109_0 (nint key);


        /// <summary>
        ///   System.Void add_CharactersChangedEvent(System.Action<Tstd2.Manager.TeamManager> value)
        /// </summary>
        /// <param name="value">class System.Action<Tstd2.Manager.TeamManager></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_CharactersChangedEvent")]
        ///  extern void ADD_CHARACTERS_CHANGED_EVENT (nint value);


        /// <summary>
        ///   System.Void AddCurrentCharacterFromTempById(System.String id, System.Boolean remove)
        /// </summary>
        /// <param name="id">class System.String</param>
        /// <param name="remove">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentCharacterFromTempById")]
        ///  extern void ADD_CURRENT_CHARACTER_FROM_TEMP_BY_ID (nint id, System.Boolean remove);


        /// <summary>
        ///   System.Void AddCurrentCharacterFromTempByOrder(System.Int32 n, System.Boolean remove)
        /// </summary>
        /// <param name="n">struct System.Int32</param>
        /// <param name="remove">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentCharacterFromTempByOrder")]
        ///  extern void ADD_CURRENT_CHARACTER_FROM_TEMP_BY_ORDER (System.Int32 n, System.Boolean remove);


        /// <summary>
        ///   System.Void AddExp(System.Int32 exp)
        /// </summary>
        /// <param name="exp">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExp")]
        extern void ADD_EXP(System.Int32 exp);


        /// <summary>
        ///   System.Void AddGoodEvilValue(System.Int32 _add)
        /// </summary>
        /// <param name="_add">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGoodEvilValue")]
        extern void ADD_GOOD_EVIL_VALUE(System.Int32 _add);


        /// <summary>
        ///   System.Void AddTempCharacterById(System.String id)
        /// </summary>
        /// <param name="id">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTempCharacterById")]
        ///  extern void ADD_TEMP_CHARACTER_BY_ID (nint id);


        /// <summary>
        ///   System.Void AddTempCharacterByOrder(System.Int32 n)
        /// </summary>
        /// <param name="n">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTempCharacterByOrder")]
        ///  extern void ADD_TEMP_CHARACTER_BY_ORDER (System.Int32 n);


        /// <summary>
        ///   System.Void Awake()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Awake")]
        ///  extern void AWAKE ();


        /// <summary>
        ///   System.Int32 CalcMaxMp(System.Int32 ler)
        /// </summary>
        /// <param name="ler">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CalcMaxMp")]
        ///  extern System.Int32 CALC_MAX_MP (System.Int32 ler);


        /// <summary>
        ///   System.Void ChangedCharactersOrder(System.Collections.Generic.List<Tstd2.Characters.Character> orderedCharacters)
        /// </summary>
        /// <param name="orderedCharacters">class System.Collections.Generic.List<Tstd2.Characters.Character></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ChangedCharactersOrder")]
        ///  extern void CHANGED_CHARACTERS_ORDER (nint orderedCharacters);


        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
        /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);


        /// <summary>
        ///   System.Void ClearTempCharacters()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearTempCharacters")]
        ///  extern void CLEAR_TEMP_CHARACTERS ();


        /// <summary>
        /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
        /// </summary>
        /// <param name="lhs">class UnityEngine.Object</param>
        /// <param name="rhs">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareBaseObjects")]
        /// static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs, nint rhs);


        /// <summary>
        ///   System.Boolean CompareTag(System.String tag)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTag")]
        ///  extern System.Boolean COMPARE_TAG (nint tag);


        /// <summary>
        /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
        /// </summary>
        /// <param name="target">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DontDestroyOnLoad")]
        /// static extern void DONT_DESTROY_ON_LOAD (nint target);


        /// <summary>
        ///   System.Boolean Equals(System.Object other)
        /// </summary>
        /// <param name="other">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
        ///  extern System.Boolean EQUALS (nint other);


        /// <summary>
        ///   System.Void EquipmentAchievement(System.String tag)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EquipmentAchievement")]
        ///  extern void EQUIPMENT_ACHIEVEMENT (nint tag);


        /// <summary>
        /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectFromInstanceID")]
        /// static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeAll")]
        /// static extern nint FIND_OBJECTS_OF_TYPE_ALL (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeIncludingAssets")]
        /// static extern nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindSceneObjectsOfType")]
        /// static extern nint FIND_SCENE_OBJECTS_OF_TYPE (nint type);


        /// <summary>
        /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceLoadFromInstanceID")]
        /// static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// <summary>
        ///   System.Void ForceRefresh()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceRefresh")]
        ///  extern void FORCE_REFRESH ();


        /// <summary>
        ///   System.Void GameInit(Tstd2.Settings.GameConfig config)
        /// </summary>
        /// <param name="config">class Tstd2.Settings.GameConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GameInit")]
        ///  extern void GAME_INIT (nint config);


        /// <summary>
        ///   System.Void GameStart(Tstd2.Settings.GameConfig config)
        /// </summary>
        /// <param name="config">class Tstd2.Settings.GameConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GameStart")]
        ///  extern void GAME_START (nint config);


        /// <summary>
        ///   Tstd2.Characters.Character get_Adviser()
        /// </summary>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Adviser")]
        ///  extern nint GET_ADVISER ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Formation> get_AdviserFormations()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Formation></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdviserFormations")]
        ///  extern nint GET_ADVISER_FORMATIONS ();


        /// <summary>
        ///   System.Int32 get_AdviserIndex()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdviserIndex")]
        ///  extern System.Int32 GET_ADVISER_INDEX ();


        /// <summary>
        ///   System.Int32 get_AdviserMaxMp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdviserMaxMp")]
        ///  extern System.Int32 GET_ADVISER_MAX_MP ();


        /// <summary>
        ///   System.Int32 get_AdviserMinLer()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdviserMinLer")]
        ///  extern System.Int32 GET_ADVISER_MIN_LER ();


        /// <summary>
        ///   System.String get_AdviserName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdviserName")]
        ///  extern nint GET_ADVISER_NAME ();


        /// <summary>
        ///   UnityEngine.Sprite get_AdviserProfile()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdviserProfile")]
        ///  extern nint GET_ADVISER_PROFILE ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Skill> get_AdviserSkills()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Skill></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AdviserSkills")]
        ///  extern nint GET_ADVISER_SKILLS ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Characters.Character> get_AliveCharacters()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Characters.Character></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AliveCharacters")]
        ///  extern nint GET_ALIVE_CHARACTERS ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Characters.Character> get_Characters()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Characters.Character></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Characters")]
        ///  extern nint GET_CHARACTERS ();


        /// <summary>
        ///   Tstd2.Skills.Formation get_CurrentFormation()
        /// </summary>
        /// <returns>class Tstd2.Skills.Formation</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentFormation")]
        ///  extern nint GET_CURRENT_FORMATION ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Formation> get_CurrentFormations()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Formation></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentFormations")]
        ///  extern nint GET_CURRENT_FORMATIONS ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Skill> get_CurrentSkills()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Skill></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentSkills")]
        ///  extern nint GET_CURRENT_SKILLS ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Characters.Character> get_DeadCharacters()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Characters.Character></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DeadCharacters")]
        ///  extern nint GET_DEAD_CHARACTERS ();


        /// <summary>
        ///   System.Boolean get_enabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enabled")]
        ///  extern System.Boolean GET_ENABLED ();


        /// <summary>
        ///   System.Collections.Generic.List<System.String> get_EventKeys()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<System.String></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EventKeys")]
        ///  extern nint GET_EVENT_KEYS ();


        /// <summary>
        ///   System.Int32 get_Exp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Exp")]
        extern System.Int32 GET_EXP();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Formation> get_FormationsInBattle()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Formation></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FormationsInBattle")]
        ///  extern nint GET_FORMATIONS_IN_BATTLE ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Formation> get_FormationsInNormal()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Formation></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FormationsInNormal")]
        ///  extern nint GET_FORMATIONS_IN_NORMAL ();


        /// <summary>
        ///   UnityEngine.GameObject get_gameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameObject")]
        ///  extern nint GET_GAME_OBJECT ();


        /// <summary>
        ///   Tstd2.Characters.Character get_General()
        /// </summary>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_General")]
        ///  extern nint GET_GENERAL ();


        /// <summary>
        ///   System.String get_GeneralName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GeneralName")]
        ///  extern nint GET_GENERAL_NAME ();


        /// <summary>
        ///   UnityEngine.Sprite get_GeneralProfile()
        /// </summary>
        /// <returns>class UnityEngine.Sprite</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GeneralProfile")]
        ///  extern nint GET_GENERAL_PROFILE ();


        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hideFlags")]
        ///  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// <summary>
        ///   System.Boolean get_isActiveAndEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isActiveAndEnabled")]
        ///  extern System.Boolean GET_IS_ACTIVE_AND_ENABLED ();


        /// <summary>
        ///   System.Boolean get_IsCanJoinCurrentCharacters()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsCanJoinCurrentCharacters")]
        ///  extern System.Boolean GET_IS_CAN_JOIN_CURRENT_CHARACTERS ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Characters.Character> get_JoinBattleCharacters()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Characters.Character></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_JoinBattleCharacters")]
        ///  extern nint GET_JOIN_BATTLE_CHARACTERS ();

        /// <summary>
        ///   System.Int32 get_Lv()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Lv")]
        extern System.Int32 GET_LV();


        /// <summary>
        ///   System.Int32 get_MaxMoveCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MaxMoveCount")]
        ///  extern System.Int32 GET_MAX_MOVE_COUNT ();


        /// <summary>
        ///   System.Int32 get_MaxMp()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MaxMp")]
        extern System.Int32 GET_MAX_MP();


        /// <summary>
        /// static  System.Int32 get_MaxValue()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MaxValue")]
        /// static extern System.Int32 GET_MAX_VALUE ();


        /// <summary>
        ///   System.Int32 get_Money()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Money")]
        extern System.Int32 GET_MONEY();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Characters.Character> get_MoveCharacters()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Characters.Character></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MoveCharacters")]
        ///  extern nint GET_MOVE_CHARACTERS ();


        /// <summary>
        ///   System.Int32 get_MP()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MP")]
        extern System.Int32 GET_MP();


        /// <summary>
        ///   System.Single get_MpRatio()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MpRatio")]
        ///  extern System.Single GET_MP_RATIO ();


        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
        ///  extern nint GET_NAME ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Characters.Character> get_NpcMoveCharacters()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Characters.Character></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NpcMoveCharacters")]
        ///  extern nint GET_NPC_MOVE_CHARACTERS ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Skill> get_SkillsInBattle()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Skill></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SkillsInBattle")]
        ///  extern nint GET_SKILLS_IN_BATTLE ();


        /// <summary>
        ///   System.Collections.Generic.List<Tstd2.Skills.Skill> get_SkillsInNormal()
        /// </summary>
        /// <returns>class System.Collections.Generic.List<Tstd2.Skills.Skill></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SkillsInNormal")]
        ///  extern nint GET_SKILLS_IN_NORMAL ();


        /// <summary>
        ///   System.String get_tag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
        ///  extern nint GET_TAG ();


        /// <summary>
        ///   System.String get_TeamName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TeamName")]
        ///  extern nint GET_TEAM_NAME ();


        /// <summary>
        ///   UnityEngine.Transform get_transform()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
        ///  extern nint GET_TRANSFORM ();


        /// <summary>
        ///   System.Boolean get_useGUILayout()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_useGUILayout")]
        ///  extern System.Boolean GET_USE_GUI_LAYOUT ();


        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
        ///  extern System.IntPtr GET_CACHED_PTR ();


        /// <summary>
        ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="oneFurtherThanResultValue">struct System.IntPtr</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentFastPath")]
        ///  extern void GET_COMPONENT_FAST_PATH (nint type, System.IntPtr oneFurtherThanResultValue);


        /// <summary>
        ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
        /// </summary>
        /// <param name="searchType">abstract class System.Type</param>
        /// <param name="resultList">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsForListInternal")]
        ///  extern void GET_COMPONENTS_FOR_LIST_INTERNAL (nint searchType, nint resultList);


        /// <summary>
        ///   System.Int32 GetEventValue(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEventValue")]
        ///  extern System.Int32 GET_EVENT_VALUE (nint key);


        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   System.Int32 GetInstanceID()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
        ///  extern System.Int32 GET_INSTANCE_ID ();


        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
        /// static extern nint GET_NAME (nint obj);


        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOffsetOfInstanceIDInCPlusPlusObject")]
        /// static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// <summary>
        ///   System.String GetScriptClassName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetScriptClassName")]
        ///  extern nint GET_SCRIPT_CLASS_NAME ();


        /// <summary>
        ///   System.Void HealAllHp(System.Boolean resurrect)
        /// </summary>
        /// <param name="resurrect">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HealAllHp")]
        ///  extern void HEAL_ALL_HP (System.Boolean resurrect);


        /// <summary>
        ///   System.Void InitEvents(System.Collections.Generic.List<System.String> keys)
        /// </summary>
        /// <param name="keys">class System.Collections.Generic.List<System.String></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitEvents")]
        ///  extern void INIT_EVENTS (nint keys);


        /// <summary>
        /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CancelInvokeAll")]
        /// static extern void INTERNAL_CANCEL_INVOKE_ALL (nint self);


        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingle")]
        /// static extern nint INTERNAL_CLONE_SINGLE (nint data);


        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingleWithParent")]
        /// static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle_Injected")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent_Injected")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data, nint parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);


        /// <summary>
        /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_IsInvokingAll")]
        /// static extern System.Boolean INTERNAL_IS_INVOKING_ALL (nint self);


        /// <summary>
        ///   System.Void Invoke(System.String methodName, System.Single time)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="time">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Invoke")]
        ///  extern void INVOKE (nint methodName, System.Single time);


        /// <summary>
        /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <param name="time">struct System.Single</param>
        /// <param name="repeatRate">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeDelayed")]
        /// static extern void INVOKE_DELAYED (nint self, nint methodName, System.Single time, System.Single repeatRate);


        /// <summary>
        ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="time">struct System.Single</param>
        /// <param name="repeatRate">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InvokeRepeating")]
        ///  extern void INVOKE_REPEATING (nint methodName, System.Single time, System.Single repeatRate);


        /// <summary>
        ///   System.Boolean IsAdviser(Tstd2.Characters.Character character)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsAdviser")]
        ///  extern System.Boolean IS_ADVISER (nint character);


        /// <summary>
        ///   System.Boolean IsCanLeaveCurrentCharacters(Tstd2.Characters.Character character)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCanLeaveCurrentCharacters")]
        ///  extern System.Boolean IS_CAN_LEAVE_CURRENT_CHARACTERS (nint character);


        /// <summary>
        /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
        /// </summary>
        /// <param name="o">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNativeObjectAlive")]
        /// static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);


        /// <summary>
        /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsObjectMonoBehaviour")]
        /// static extern System.Boolean IS_OBJECT_MONO_BEHAVIOUR (nint obj);


        /// <summary>
        ///   System.Int32 ItemCount(Tstd2.Inventory.Item item, System.Boolean calcEquip)
        /// </summary>
        /// <param name="item">class Tstd2.Inventory.Item</param>
        /// <param name="calcEquip">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ItemCount")]
        extern System.Int32 ITEM_COUNT(nint item, System.Boolean calcEquip);


        /// <summary>
        ///   System.Void JoinAlternateCharacters(Tstd2.Characters.Character character, System.Boolean healHp)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="healHp">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("JoinAlternateCharacters")]
        extern void JOIN_ALTERNATE_CHARACTERS(nint character, System.Boolean healHp);


        /// <summary>
        ///   System.Void JoinCurrentCharacters(Tstd2.Characters.Character character, System.Boolean autoEquip, System.Boolean healHp, System.Int32 index)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="autoEquip">struct System.Boolean</param>
        /// <param name="healHp">struct System.Boolean</param>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("JoinCurrentCharacters")]
        extern void JOIN_CURRENT_CHARACTERS(nint character, System.Boolean autoEquip, System.Boolean healHp, System.Int32 index);


        /// <summary>
        ///   System.Void JoinNpcCharacters(Tstd2.Characters.Character character)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("JoinNpcCharacters")]
        extern void JOIN_NPC_CHARACTERS(nint character);


        /// <summary>
        ///   System.Boolean JoinTeam(Tstd2.Characters.Character character, System.Boolean autoEquip, System.Boolean healHp)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="autoEquip">struct System.Boolean</param>
        /// <param name="healHp">struct System.Boolean</param>
        /// <returns>struct System.Boolean</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("JoinTeam")]
        extern System.Boolean JOIN_TEAM(nint character, System.Boolean autoEquip, System.Boolean healHp);


        /// <summary>
        ///   System.Void LeaveAlternateCharacters(Tstd2.Characters.Character character, System.Boolean autoUnload)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="autoUnload">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LeaveAlternateCharacters")]
        ///  extern void LEAVE_ALTERNATE_CHARACTERS (nint character, System.Boolean autoUnload);


        /// <summary>
        ///   System.Void LeaveNpcCharacters(Tstd2.Characters.Character character, System.Boolean autoUnload)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="autoUnload">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LeaveNpcCharacters")]
        ///  extern void LEAVE_NPC_CHARACTERS (nint character, System.Boolean autoUnload);


        /// <summary>
        ///   System.Void LevelTo(System.Int32 lv)
        /// </summary>
        /// <param name="lv">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LevelTo")]
        extern void LEVEL_TO(System.Int32 lv);


        /// <summary>
        ///   System.Int32 MaxMpInLv(System.Int32 lv)
        /// </summary>
        /// <param name="lv">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MaxMpInLv")]
        extern System.Int32 MAX_MP_IN_LV(System.Int32 lv);


        /// <summary>
        /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
        /// static extern System.Boolean OP_EQUALITY (nint x, nint y);


        /// <summary>
        /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
        /// </summary>
        /// <param name="exists">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
        /// static extern System.Boolean OP_IMPLICIT (nint exists);


        /// <summary>
        /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
        /// static extern System.Boolean OP_INEQUALITY (nint x, nint y);


        /// <summary>
        /// static  System.Void print(System.Object message)
        /// </summary>
        /// <param name="message">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("print")]
        /// static extern void PRINT (nint message);


        /// <summary>
        ///   System.Void remove_CharactersChangedEvent(System.Action<Tstd2.Manager.TeamManager> value)
        /// </summary>
        /// <param name="value">class System.Action<Tstd2.Manager.TeamManager></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_CharactersChangedEvent")]
        ///  extern void REMOVE_CHARACTERS_CHANGED_EVENT (nint value);


        /// <summary>
        ///   System.Void set_Adviser(Tstd2.Characters.Character value)
        /// </summary>
        /// <param name="value">class Tstd2.Characters.Character</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Adviser")]
        ///  extern void SET_ADVISER (nint value);


        /// <summary>
        ///   System.Void set_CurrentFormation(Tstd2.Skills.Formation value)
        /// </summary>
        /// <param name="value">class Tstd2.Skills.Formation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CurrentFormation")]
        ///  extern void SET_CURRENT_FORMATION (nint value);


        /// <summary>
        ///   System.Void set_enabled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_enabled")]
        ///  extern void SET_ENABLED (System.Boolean value);


        /// <summary>
        ///   System.Void set_Exp(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Exp")]
        extern void SET_EXP(System.Int32 value);


        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hideFlags")]
        ///  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);

        /// <summary>
        ///   System.Void set_Lv(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Lv")]
        extern void SET_LV(System.Int32 value);


        /// <summary>
        ///   System.Void set_MaxMp(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MaxMp")]
        extern void SET_MAX_MP(System.Int32 value);


        /// <summary>
        ///   System.Void set_Money(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Money")]
        extern void SET_MONEY(System.Int32 value);


        /// <summary>
        ///   System.Void set_MP(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MP")]
        extern void SET_MP(System.Int32 value);


        /// <summary>
        ///   System.Void set_MpRatio(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MpRatio")]
        ///  extern void SET_MP_RATIO (System.Single value);


        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_tag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_tag")]
        ///  extern void SET_TAG (nint value);


        /// <summary>
        ///   System.Void set_useGUILayout(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_useGUILayout")]
        ///  extern void SET_USE_GUI_LAYOUT (System.Boolean value);


        /// <summary>
        ///   System.Void SetEventKey(System.String key, System.Int32 value)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEventKey")]
        ///  extern void SET_EVENT_KEY (nint key, System.Int32 value);


        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
        /// static extern void SET_NAME (nint obj, nint name);


        /// <summary>
        ///   System.Void SingleInstanceAwake()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SingleInstanceAwake")]
        ///  extern void SINGLE_INSTANCE_AWAKE ();


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine_Auto")]
        ///  extern nint START_COROUTINE_AUTO (nint routine);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged")]
        ///  extern nint START_COROUTINE_MANAGED (nint methodName, nint value);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
        /// </summary>
        /// <param name="enumerator">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutineManaged2")]
        ///  extern nint START_COROUTINE_MANAGED2 (nint enumerator);


        /// <summary>
        ///   System.Void StopAllCoroutines()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopAllCoroutines")]
        ///  extern void STOP_ALL_COROUTINES ();


        /// <summary>
        ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineFromEnumeratorManaged")]
        ///  extern void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED (nint routine);


        /// <summary>
        ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
        /// </summary>
        /// <param name="routine">class UnityEngine.Coroutine</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutineManaged")]
        ///  extern void STOP_COROUTINE_MANAGED (nint routine);


        /// <summary>
        ///   System.Void UnlockAchievements(System.String tag)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnlockAchievements")]
        ///  extern void UNLOCK_ACHIEVEMENTS (nint tag);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_TeamManager))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_TeamManager))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_TeamManager))]
        ///  extern void .CTOR_02 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_TeamManager))]
        ///  extern void .CTOR_03 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_TeamManager))]
        ///  extern void .CTOR_04 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_TeamManager))]
        ///  extern void .CTOR_05 ();


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="parameter">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_TeamManager))]
        ///  extern void BROADCAST_MESSAGE_00 (nint methodName, nint parameter, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="parameter">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_TeamManager))]
        ///  extern void BROADCAST_MESSAGE_01 (nint methodName, nint parameter);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_TeamManager))]
        ///  extern void BROADCAST_MESSAGE_02 (nint methodName);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_TeamManager))]
        ///  extern void BROADCAST_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void CancelInvoke()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_TeamManager))]
        ///  extern void CANCEL_INVOKE_00 ();


        /// <summary>
        ///   System.Void CancelInvoke(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_TeamManager))]
        ///  extern void CANCEL_INVOKE_01 (nint methodName);


        /// <summary>
        /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CancelInvoke", Search = typeof(Search_TeamManager))]
        /// static extern void CANCEL_INVOKE_02 (nint self, nint methodName);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_TeamManager))]
        /// static extern void DESTROY_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_TeamManager))]
        /// static extern void DESTROY_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_TeamManager))]
        /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_TeamManager))]
        /// static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_TeamManager))]
        /// static extern void DESTROY_OBJECT_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_TeamManager))]
        /// static extern void DESTROY_OBJECT_01 (nint obj);


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  Tstd2.Characters.Character FindCharacterById(System.Collections.Generic.List<Tstd2.Characters.Character> characters, System.String id)
        /// </summary>
        /// <param name="characters">class System.Collections.Generic.List<Tstd2.Characters.Character></param>
        /// <param name="id">class System.String</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindCharacterById", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_CHARACTER_BY_ID_00 (nint characters, nint id);


        /// <summary>
        /// static  Tstd2.Characters.Character FindCharacterById(System.Collections.Generic.List<Tstd2.Characters.Character>[] charactersList, System.String id)
        /// </summary>
        /// <param name="charactersList">class System.Collections.Generic.List<Tstd2.Characters.Character>[]</param>
        /// <param name="id">class System.String</param>
        /// <returns>class Tstd2.Characters.Character</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindCharacterById", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_CHARACTER_BY_ID_01 (nint charactersList, nint id);


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECT_OF_TYPE_03 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_00 (nint type, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_01 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_02 (UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_03 (UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_TeamManager))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_00 (nint type);


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_01 ();


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.String type)
        /// </summary>
        /// <param name="type">class System.String</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_02 (nint type);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_03 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T GetComponentInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENT_IN_PARENT_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponents(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_00 (nint type);


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_TeamManager))]
        ///  extern void GET_COMPONENTS_01 (nint type, nint results);


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_TeamManager))]
        ///  extern void GET_COMPONENTS_02 (nint results);


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="result">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_TeamManager))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_03 (System.Boolean includeInactive, nint result);


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_04 ();


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_TeamManager))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_05 (nint results);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_TeamManager))]
        ///  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive, nint results);


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_TeamManager))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_04 ();


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_02 (nint original);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_03 (nint original, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_04 (nint original, nint parent, System.Boolean instantiateInWorldSpace);


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_05 (nint original);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_07 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_08 (nint original, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_TeamManager))]
        /// static extern nint INSTANTIATE_09 (nint original, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        ///   System.Boolean IsInvoking()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_TeamManager))]
        ///  extern System.Boolean IS_INVOKING_00 ();


        /// <summary>
        ///   System.Boolean IsInvoking(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_TeamManager))]
        ///  extern System.Boolean IS_INVOKING_01 (nint methodName);


        /// <summary>
        /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// <param name="self">class UnityEngine.MonoBehaviour</param>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInvoking", Search = typeof(Search_TeamManager))]
        /// static extern System.Boolean IS_INVOKING_02 (nint self, nint methodName);


        /// <summary>
        ///   System.Void LeaveCurrentCharacters(Tstd2.Characters.Character character, System.Int32 index, System.Boolean autoUnload)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="autoUnload">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LeaveCurrentCharacters", Search = typeof(Search_TeamManager))]
        ///  extern void LEAVE_CURRENT_CHARACTERS_00 (nint character, System.Int32 index, System.Boolean autoUnload);


        /// <summary>
        ///   System.Void LeaveCurrentCharacters(Tstd2.Characters.Character character, System.Boolean autoUnload)
        /// </summary>
        /// <param name="character">class Tstd2.Characters.Character</param>
        /// <param name="autoUnload">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LeaveCurrentCharacters", Search = typeof(Search_TeamManager))]
        ///  extern void LEAVE_CURRENT_CHARACTERS_01 (nint character, System.Boolean autoUnload);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_00 (nint methodName, nint value);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_01 (nint methodName);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_02 (nint methodName, nint value, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_UPWARDS_00 (nint methodName, nint value, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_UPWARDS_01 (nint methodName, nint value);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_UPWARDS_02 (nint methodName);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_TeamManager))]
        ///  extern void SEND_MESSAGE_UPWARDS_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_TeamManager))]
        ///  extern nint START_COROUTINE_00 (nint methodName);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_TeamManager))]
        ///  extern nint START_COROUTINE_01 (nint methodName, nint value);


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>class UnityEngine.Coroutine</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartCoroutine", Search = typeof(Search_TeamManager))]
        ///  extern nint START_COROUTINE_02 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// <param name="routine">interface System.Collections.IEnumerator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_TeamManager))]
        ///  extern void STOP_COROUTINE_00 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
        /// </summary>
        /// <param name="routine">class UnityEngine.Coroutine</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_TeamManager))]
        ///  extern void STOP_COROUTINE_01 (nint routine);


        /// <summary>
        ///   System.Void StopCoroutine(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopCoroutine", Search = typeof(Search_TeamManager))]
        ///  extern void STOP_COROUTINE_02 (nint methodName);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_TeamManager))]
        ///  extern nint TO_STRING_00 ();


        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_TeamManager))]
        /// static extern nint TO_STRING_01 (nint obj);


        /// <summary>
        ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="component">class UnityEngine.Component&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_TeamManager))]
        ///  extern System.Boolean TRY_GET_COMPONENT_00 (nint type, nint component);


        /// <summary>
        ///   System.Boolean TryGetComponent(T& component)
        /// </summary>
        /// <param name="component">class T&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_TeamManager))]
        ///  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);


        /// public static partial class Search_TeamManager
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


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CancelInvoke()
        /// </summary>
        /// public static bool CANCEL_INVOKE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CancelInvoke(System.String methodName)
        /// </summary>
        /// public static bool CANCEL_INVOKE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// public static bool CANCEL_INVOKE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CancelInvoke", "UnityEngine.MonoBehaviour", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// public static bool DESTROY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// public static bool DESTROY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// public static bool DESTROY_IMMEDIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// public static bool DESTROY_IMMEDIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// public static bool DESTROY_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// public static bool DESTROY_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Tstd2.Characters.Character FindCharacterById(System.Collections.Generic.List<Tstd2.Characters.Character> characters, System.String id)
        /// </summary>
        /// public static bool FIND_CHARACTER_BY_ID_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindCharacterById", "System.Collections.Generic.List<Tstd2.Characters.Character>", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Tstd2.Characters.Character FindCharacterById(System.Collections.Generic.List<Tstd2.Characters.Character>[] charactersList, System.String id)
        /// </summary>
        /// public static bool FIND_CHARACTER_BY_ID_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindCharacterById", "System.Collections.Generic.List<Tstd2.Characters.Character>[]", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// public static bool GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// public static bool GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.String type)
        /// </summary>
        /// public static bool GET_COMPONENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInParent(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponents(System.Type type)
        /// </summary>
        /// public static bool GET_COMPONENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type", "System.Collections.Generic.List<UnityEngine.Component>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// public static bool GET_COMPONENTS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// public static bool INSTANTIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// public static bool INSTANTIATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// public static bool INSTANTIATE_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean IsInvoking()
        /// </summary>
        /// public static bool IS_INVOKING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean IsInvoking(System.String methodName)
        /// </summary>
        /// public static bool IS_INVOKING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
        /// </summary>
        /// public static bool IS_INVOKING_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsInvoking", "UnityEngine.MonoBehaviour", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LeaveCurrentCharacters(Tstd2.Characters.Character character, System.Int32 index, System.Boolean autoUnload)
        /// </summary>
        /// public static bool LEAVE_CURRENT_CHARACTERS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LeaveCurrentCharacters", "Tstd2.Characters.Character", "System.Int32", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LeaveCurrentCharacters(Tstd2.Characters.Character character, System.Boolean autoUnload)
        /// </summary>
        /// public static bool LEAVE_CURRENT_CHARACTERS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LeaveCurrentCharacters", "Tstd2.Characters.Character", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value)
        /// </summary>
        /// public static bool SEND_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessage(System.String methodName)
        /// </summary>
        /// public static bool SEND_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool SEND_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool SEND_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool SEND_MESSAGE_UPWARDS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
        /// </summary>
        /// public static bool SEND_MESSAGE_UPWARDS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName)
        /// </summary>
        /// public static bool SEND_MESSAGE_UPWARDS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool SEND_MESSAGE_UPWARDS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
        /// </summary>
        /// public static bool START_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
        /// </summary>
        /// public static bool START_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.String", "System.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// public static bool START_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StartCoroutine", "System.Collections.IEnumerator");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
        /// </summary>
        /// public static bool STOP_COROUTINE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.Collections.IEnumerator");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
        /// </summary>
        /// public static bool STOP_COROUTINE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "UnityEngine.Coroutine");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void StopCoroutine(System.String methodName)
        /// </summary>
        /// public static bool STOP_COROUTINE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopCoroutine", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
        /// </summary>
        /// public static bool TRY_GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "System.Type", "UnityEngine.Component&");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean TryGetComponent(T& component)
        /// </summary>
        /// public static bool TRY_GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "T&");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}