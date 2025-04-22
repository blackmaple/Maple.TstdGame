using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.TstdMetadata
{
    public partial class TstdGameEnvironment(TstdGameContext context)
    {
        public class GameItemEntrys(string name, int min, int max)
        {
            public string Name { get; } = name;
            public int Min { get; } = min;
            public int Max { get; } = max + 1;
            public override string ToString()
            {
                return $"{Name}:{Random.Shared.Next(Min, Max)}";
            }
        }
        static GameItemEntrys[] ItemEntrys =
            [
new("攻",15, 30),
new("兵",15, 500),
new("防",15, 30),
new("智",15, 30),
new("武",15, 30),
new("速",15, 30),
new("暴击率",15, 30),
new("暴击伤害",15, 30),
new("计策增伤",15, 30),
new("计策防御",15, 30),
new("闪避",15, 30),
new("命中",15, 30),
new("神算",15, 30),

            ];
        public static List<GameInventoryDisplayDTO> CacheCharacters { get; } = new(1024);
        public static List<GameInventoryDisplayDTO> CacheConsumables { get; } = new(1024);
        public static List<GameInventoryDisplayDTO> CacheItems { get; } = new(1024);
        public static List<GameInventoryDisplayDTO> CacheEquipment { get; } = new(1024);

        public TstdGameContext Context { get; } = context;
        public ResourceManager ResourceManager => Context.ResourceManager;
        public ILogger Logger => Context.Logger;
        public TeamManager.Ptr_TeamManager Ptr_TeamManager => Context.TeamManager.INSTANCE;
        public GameManager.Ptr_GameManager Ptr_GameManager => Context.GameManager.INSTANCE;
        public Inventorys.Ptr_Inventorys Ptr_Inventorys => Ptr_TeamManager.INVENTORY;
        public InGameResource.Ptr_InGameResource Ptr_InGameResource => Context.InGameResource.INSTANCE;
        public bool InGame()
        {
            return this.Ptr_TeamManager.CHARACTERS_CHANGED_EVENT != nint.Zero;
        }



        public Item.Ptr_Item NewItem(string id)
        {
            using var tagId = Context.T2(id);
            return Item.Ptr_Item.LOAD_ITEM(tagId, nint.Zero);
        }
        public Equipment.Ptr_Equipment NewEquipment(string id)
        {
            var att = string.Join(',', Random.Shared.GetItems(ItemEntrys, 6).Select(p => p.ToString()));
            var entrys = Context.T2(att);

            using var tagId = Context.T2(id);
            return Item.Ptr_Item.LOAD_EQUIPMENT(tagId, entrys);
        }
        public Character.Ptr_Character NewCharacter(string id)
        {
            using var tagId = Context.T2(id);
            return Character.Ptr_Character.LOAD_PLAYER_CHARACTER(tagId);
        }


    }

    public static class TstdGameContextExtensions
    {
        public static TstdGameEnvironment GetTstdGameEnvironment(this TstdGameContext @this)
            => new(@this);

        public static string? Test(this TstdGameEnvironment @this, string str)
        {
            using var t = @this.Context.T2(str);
            var code = @this.Ptr_GameManager.SIMPLE_DECRYPT(t);
            return code.ToString();
        }

        static PMonoString InitResource(this TstdGameEnvironment @this)
        {
            var tagId = @this.Context.T2("maple");
            _ = Character.Ptr_Character.LOAD_PLAYER_CHARACTER(tagId);
            _ = Item.Ptr_Item.LOAD_EQUIPMENT(tagId, nint.Zero);
            _ = Item.Ptr_Item.LOAD_ITEM(tagId, nint.Zero);
            return tagId;
        }

        public static void WaitLoadResourceData(this TstdGameEnvironment @this)
        {
            SpinWait.SpinUntil(() =>
            {
                var resources = @this.ResourceManager._DICTIONARY4;
                if (resources.Valid())
                {
                    return @this.LoadResourceData(@this.ResourceManager._DICTIONARY4);
                }
                return false;
            });
        }

        public static void LoadResourceDataIfThrowNotInit(this TstdGameEnvironment @this)
        {
            var resources = @this.ResourceManager._DICTIONARY4;
            if (false == resources.Valid())
            {
                GameException.Throw("NOT INIT:ResourceManager");
            }

            @this.LoadResourceData(resources);

        }

        public static bool LoadResourceData(this TstdGameEnvironment @this, Maple.MonoGameAssistant.Core.PMonoDictionary_OptimizationDefault<Maple.MonoGameAssistant.Core.PMonoString, Maple.MonoGameAssistant.Core.PMonoDictionary_OptimizationDefault<Maple.MonoGameAssistant.Core.PMonoString, Maple.TstdMetadata.TagResource.Ptr_TagResource>> resources)
        {
            @this.InitResource();
            foreach (var resource in resources.AsRefArray())
            {

                var span_key = resource.Key.AsReadOnlySpan();

                @this.Logger.Info(span_key.ToString());

                if (span_key.SequenceEqual(ResourceModule.ResourceModule_PlayerCharacters))
                {

                    var tags = resource.Value.AsRefArray();
                    foreach (var tag in tags)
                    {

                        var tagId = tag.Value.TAG;

                        var objectId = tagId.ToString()!;

                        //  var pCharacter = Character.Ptr_Character.LOAD_PLAYER_CHARACTER(tagId);
                        var pCharacter = @this.Ptr_InGameResource.GET_CHARACTER_MODEL_DATA(tagId);
                        if (pCharacter)
                        {

                            TstdGameEnvironment.CacheCharacters.Add(new GameInventoryDisplayDTO()
                            {
                                ObjectId = objectId,
                                DisplayCategory = EnumGameInventoryType.Character.ToString(),
                                DisplayName = pCharacter.CHARACTER_NAME.ToString(),
                                DisplayDesc = $"{objectId}:{pCharacter.STYLE_NAME}",
                            });
                            //                       @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_PlayerCharacters, objectId);

                        }
                    }
                }
                else if (span_key.SequenceEqual(ResourceModule.ResourceModule_Equipments))
                {

                    var tags = resource.Value.AsRefArray();
                    foreach (var tag in tags)
                    {
                        var tagId = tag.Value.TAG;
                        var objectId = tagId.ToString()!;
                        var pItem = Item.Ptr_Item.LOAD_EQUIPMENT(tagId, nint.Zero);
                        if (pItem)
                        {

                            TstdGameEnvironment.CacheEquipment.Add(new GameInventoryDisplayDTO()
                            {
                                ObjectId = objectId,
                                DisplayCategory = EnumGameInventoryType.Equipment.ToString(),
                                DisplayName = pItem.ITEM_NAME.ToString(),
                                DisplayDesc = pItem.DESC.ToString(),
                            });
                            //                       @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_Equipments, objectId);

                        }
                    }

                }
                else if (span_key.SequenceEqual(ResourceModule.ResourceModule_Consumables))
                {
                    var tags = resource.Value.AsRefArray();
                    foreach (var tag in tags)
                    {
                        var tagId = tag.Value.TAG;
                        var objectId = tagId.ToString()!;
                        var pItem = Item.Ptr_Item.LOAD_ITEM(tagId, nint.Zero);
                        if (pItem)
                        {

                            TstdGameEnvironment.CacheConsumables.Add(new GameInventoryDisplayDTO()
                            {
                                ObjectId = objectId,
                                DisplayCategory = EnumGameInventoryType.Consumable.ToString(),
                                DisplayName = pItem.ITEM_NAME.ToString(),
                                DisplayDesc = pItem.DESC.ToString(),
                            });
                            //                    @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_Consumables, objectId);

                        }

                    }
                }
                else if (span_key.SequenceEqual(ResourceModule.ResourceModule_Items))
                {
                    var tags = resource.Value.AsRefArray();
                    foreach (var tag in tags)
                    {
                        var tagId = tag.Value.TAG;
                        var objectId = tagId.ToString()!;
                        var pItem = Item.Ptr_Item.LOAD_ITEM(tagId, nint.Zero);
                        if (pItem)
                        {

                            TstdGameEnvironment.CacheItems.Add(new GameInventoryDisplayDTO()
                            {
                                ObjectId = objectId,
                                DisplayCategory = EnumGameInventoryType.Item.ToString(),
                                DisplayName = pItem.ITEM_NAME.ToString(),
                                DisplayDesc = pItem.DESC.ToString(),
                            });
                            //                   @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_Items, objectId);

                        }


                    }
                }
                else
                {
                    foreach (var item in resource.Value.AsRefArray())
                    {
                        if (item.Value)
                        {
                            @this.Logger.LogInformation("item:{key}/{tag}", item.Key.ToString(), item.Value.TAG.ToString());
                        }
                    }
                }
            }

            var cacheCharacters_count = TstdGameEnvironment.CacheCharacters.Count;
            var cacheEquipment_count = TstdGameEnvironment.CacheEquipment.Count;
            var cacheConsumables_count = TstdGameEnvironment.CacheConsumables.Count;
            var cacheItems_count = TstdGameEnvironment.CacheItems.Count;



            @this.Logger.LogInformation("{ResourceModule_PlayerCharacters}:{c}|{ResourceModule_Equipments}:{c}|{ResourceModule_Consumables}:{c}|{ResourceModule_Items}:{c}",
                ResourceModule.ResourceModule_PlayerCharacters,
                cacheCharacters_count.ToString(),

                ResourceModule.ResourceModule_Equipments,
                cacheEquipment_count.ToString(),

                ResourceModule.ResourceModule_Consumables,
                cacheConsumables_count.ToString(),

                ResourceModule.ResourceModule_Items,
                cacheItems_count.ToString());

            return cacheCharacters_count != 0
                && cacheEquipment_count != 0
                && cacheConsumables_count != 0
                && cacheItems_count != 0;

        }

        [Obsolete("test")]
        public static void LoadCharacter(this TstdGameEnvironment @this)
        {
            foreach (var item in TstdGameEnvironment.CacheCharacters)
            {
                var tagId = @this.Context.T2(item.ObjectId);
                @this.Logger.LogInformation("character:{ObjectId}", item.ObjectId);

                var pCharacter = Character.Ptr_Character.LOAD_PLAYER_CHARACTER(tagId);
                if (pCharacter.Valid())
                {
                    var baseCharacter = pCharacter._DATA;
                    if (baseCharacter)
                    {
                        var buff = baseCharacter.BUFF_DATA;
                        if (buff)
                        {
                            @this.Logger.LogInformation("character:{ObjectId}/buffer:{name}:{desc}", item.ObjectId, buff.TAG.ToString(), buff.DESC.ToString());
                        }
                        //var buff_datas = buff.BUFF_DATA;
                        //if (buff_datas.Valid())
                        //{
                        //    foreach (var b in buff_datas)
                        //    {

                        //    }
                        //}

                    }
                }
            }
        }

        public static GameCurrencyDisplayDTO[] GetGameCurrencyDisplays(this TstdGameEnvironment @this)
        {
            return [
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.MONEY.ToString(), DisplayCategory = EnumGameCurrencyType.MONEY.ToString(),DisplayName = EnumGameCurrencyType.MONEY.ToString() },
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.LV.ToString(), DisplayCategory = EnumGameCurrencyType.LV.ToString(),DisplayName = EnumGameCurrencyType.LV.ToString() },
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.EXP.ToString(), DisplayCategory = EnumGameCurrencyType.EXP.ToString(),DisplayName = EnumGameCurrencyType.EXP.ToString() },
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.MP.ToString(), DisplayCategory = EnumGameCurrencyType.MP.ToString(),DisplayName = EnumGameCurrencyType.MP.ToString() },
                ];
        }
        static GameCurrencyInfoDTO GetGameCurrencyInfoImp(this TstdGameEnvironment @this, EnumGameCurrencyType currencyType)
        {
            return currencyType switch
            {
                EnumGameCurrencyType.MONEY => new GameCurrencyInfoDTO() { ObjectId = currencyType.ToString(), DisplayValue = @this.Ptr_TeamManager.GET_MONEY().ToString() },
                EnumGameCurrencyType.EXP => new GameCurrencyInfoDTO() { ObjectId = currencyType.ToString(), DisplayValue = @this.Ptr_TeamManager.GET_EXP().ToString() },
                EnumGameCurrencyType.LV => new GameCurrencyInfoDTO() { ObjectId = currencyType.ToString(), DisplayValue = @this.Ptr_TeamManager.GET_LV().ToString() },
                EnumGameCurrencyType.MP => new GameCurrencyInfoDTO() { ObjectId = currencyType.ToString(), DisplayValue = @this.Ptr_TeamManager.GET_MP().ToString() },
                _ => GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{currencyType}")

            };
        }
        public static GameCurrencyInfoDTO GetGameCurrencyInfo(this TstdGameEnvironment @this, GameCurrencyObjectDTO objectDTO)
        {
            if (!Enum.TryParse<EnumGameCurrencyType>(objectDTO.CurrencyObject, out var currencyType))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{objectDTO.CurrencyObject}");
            }
            return @this.GetGameCurrencyInfoImp(currencyType);
        }
        public static GameCurrencyInfoDTO UpdateGameCurrencyInfo(this TstdGameEnvironment @this, GameCurrencyModifyDTO modifyDTO)
        {
            if (!Enum.TryParse<EnumGameCurrencyType>(modifyDTO.CurrencyObject, out var currencyType))
            {
                return GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND:{modifyDTO.CurrencyObject}");
            }
            if (currencyType == EnumGameCurrencyType.MONEY)
            {
                var val = Math.Clamp(modifyDTO.IntValue, 0, 99999999);
                @this.Ptr_TeamManager.SET_MONEY(val);
            }
            else if (currencyType == EnumGameCurrencyType.EXP)
            {
                var val = Math.Clamp(modifyDTO.IntValue, 0, 99999999);
                @this.Ptr_TeamManager.SET_EXP(val);
            }
            else if (currencyType == EnumGameCurrencyType.LV)
            {
                var val = Math.Clamp(modifyDTO.IntValue, 1, 99);
                @this.Ptr_TeamManager.LEVEL_TO(val);
            }
            else if (currencyType == EnumGameCurrencyType.MP)
            {
                var maxMp = @this.Ptr_TeamManager.GET_MAX_MP();
                var val = Math.Clamp(modifyDTO.IntValue, 0, maxMp);
                @this.Ptr_TeamManager.SET_MP(val);
            }

            return @this.GetGameCurrencyInfoImp(currencyType);
        }



        public static GameInventoryDisplayDTO[] GetGameInventoryDisplays(this TstdGameEnvironment @this)
        {
            return [.. TstdGameEnvironment.CacheCharacters, .. TstdGameEnvironment.CacheEquipment, .. TstdGameEnvironment.CacheConsumables, .. TstdGameEnvironment.CacheItems];
        }
        static bool TryFindItemSlot(this TstdGameEnvironment @this, ReadOnlySpan<char> tagId, out ItemSlot.Ptr_ItemSlot itemSlot)
        {
            Unsafe.SkipInit(out itemSlot);
            foreach (var slot in @this.Ptr_Inventorys.SLOTS)
            {

                if (slot.ITEM.TAG.AsReadOnlySpan().SequenceEqual(tagId))
                {
                    itemSlot = slot;
                    return true;
                }
            }
            return false;

        }

        public static GameInventoryInfoDTO GetGameInventoryInfo(this TstdGameEnvironment @this, GameInventoryObjectDTO objectDTO)
        {
            if (!Enum.TryParse<EnumGameInventoryType>(objectDTO.InventoryCategory, out var category))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{objectDTO.InventoryCategory}");
            }
            if (category == EnumGameInventoryType.Character)
            {
                var first = TstdGameEnvironment.CacheCharacters.Find(p => p.ObjectId == objectDTO.InventoryObject);
                if (first is not null)
                {
                    var count = @this.TryFindCharacter(first.ObjectId, out _) ? 1 : 0;
                    return new GameInventoryInfoDTO() { ObjectId = first.ObjectId, InventoryCount = count };
                }
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{objectDTO.InventoryObject}");
            }
            else if (category == EnumGameInventoryType.Equipment
                || category == EnumGameInventoryType.Consumable
                || category == EnumGameInventoryType.Item)
            {
                if (@this.TryFindItemSlot(objectDTO.InventoryObject, out var ptr_ItemSlot))
                {
                    var count = @this.Ptr_TeamManager.ITEM_COUNT(ptr_ItemSlot.ITEM, true);
                    return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = count };
                }
            }
            return new GameInventoryInfoDTO() { ObjectId = objectDTO.InventoryObject, InventoryCount = 0 };
        }

        static bool TryFindCharacter(this TstdGameEnvironment @this, ReadOnlySpan<char> tagId, out Character.Ptr_Character ptr_Character)
        {
            Unsafe.SkipInit(out ptr_Character);
            foreach (var character in @this.Ptr_TeamManager.CHARACTERS)
            {
                if (character._DATA.TAG.AsReadOnlySpan().SequenceEqual(tagId))
                {
                    ptr_Character = character;
                    return true;
                }
            }
            foreach (var character in @this.Ptr_TeamManager.TEMP_CHARACTERS)
            {
                if (character._DATA.TAG.AsReadOnlySpan().SequenceEqual(tagId))
                {
                    ptr_Character = character;
                    return true;
                }
            }
            foreach (var character in @this.Ptr_TeamManager.ALTERNATE_CHARACTERS)
            {
                if (character._DATA.TAG.AsReadOnlySpan().SequenceEqual(tagId))
                {
                    ptr_Character = character;
                    return true;
                }
            }
            foreach (var character in @this.Ptr_TeamManager.NPC_CHARACTERS)
            {
                if (character._DATA.TAG.AsReadOnlySpan().SequenceEqual(tagId))
                {
                    ptr_Character = character;
                    return true;
                }
            }
            return false;
        }


        static bool TryUpdateGameInventoryInfoImp(
            this TstdGameEnvironment @this,
            GameInventoryModifyDTO modifyDTO,
            bool isEquipment,
          [MaybeNullWhen(false)] out GameInventoryInfoDTO gameInventory)
        {
            Unsafe.SkipInit(out gameInventory);
            nint item;
            if (@this.TryFindItemSlot(modifyDTO.InventoryObject, out var ptr_ItemSlot))
            {
                item = ptr_ItemSlot.ITEM;
            }
            else
            {
                item = isEquipment ? @this.NewEquipment(modifyDTO.InventoryObject) : @this.NewItem(modifyDTO.InventoryObject);
            }
            if (item != nint.Zero)
            {
                var count = @this.Ptr_TeamManager.ITEM_COUNT(item, true);
                var newCount = modifyDTO.InventoryCount - count;
                if (newCount > 0)
                {
                    @this.Ptr_Inventorys.INCREASE(item, newCount);
                }
                else
                {
                    @this.Ptr_Inventorys.DECREASE_00(item, newCount);
                }
                gameInventory = new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, InventoryCount = @this.Ptr_TeamManager.ITEM_COUNT(item, true) };
                return true;
            }
            return false;
        }

        public static GameInventoryInfoDTO UpdateGameInventoryInfo(this TstdGameEnvironment @this, GameInventoryModifyDTO modifyDTO)
        {
            if (!Enum.TryParse<EnumGameInventoryType>(modifyDTO.InventoryCategory, out var category))
            {
                return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{modifyDTO.InventoryCategory}");
            }

            if (category == EnumGameInventoryType.Character)
            {
                if (!@this.TryFindCharacter(modifyDTO.InventoryObject, out var ptr_Character))
                {
                    ptr_Character = @this.NewCharacter(modifyDTO.InventoryObject);
                }
                if (ptr_Character.Valid())
                {
                    @this.Ptr_TeamManager.JOIN_ALTERNATE_CHARACTERS(ptr_Character, true);
                    return new GameInventoryInfoDTO() { ObjectId = modifyDTO.InventoryObject, InventoryCount = 1 };
                }
            }
            else if (@this.TryUpdateGameInventoryInfoImp(modifyDTO, category == EnumGameInventoryType.Equipment, out var gameInventory))
            {
                return gameInventory;
            }
            //else if (category == EnumGameInventoryType.Item
            //    || category == EnumGameInventoryType.Consumable)
            //{
            //    if (@this.TryUpdateGameInventoryInfoImp(modifyDTO, false, out var gameInventory))
            //    {
            //        return gameInventory;
            //    }
            //}
            return GameException.Throw<GameInventoryInfoDTO>($"NOT FOUND:{modifyDTO.InventoryObject}");

        }


        private static bool TryGetGameCharacterDisplayImp(this Character.Ptr_Character ptr_Character, EnumGameCharacterType category, [MaybeNullWhen(false)] out GameCharacterDisplayDTO characterDisplayDTO)
        {
            Unsafe.SkipInit(out characterDisplayDTO);

            var data = ptr_Character._DATA;
            if (data.Valid() == false)
            {
                return false;
            }
            var characterModel = data.MODEL_DATA;
            if (characterModel.Valid() == false)
            {
                var objectId = data.TAG.ToString()!;
                var firstCharacter = TstdGameEnvironment.CacheCharacters.Find(p => p.ObjectId.AsSpan().SequenceEqual(objectId.AsSpan()));
                if (firstCharacter is null)
                {
                    return false;
                }
                characterDisplayDTO = new GameCharacterDisplayDTO()
                {
                    ObjectId = objectId!,
                    DisplayCategory = category.ToString(),
                    DisplayName = firstCharacter.DisplayName,
                    DisplayDesc = firstCharacter.DisplayDesc,

                };
                return true;
            }
            else
            {

                var objectId = characterModel.TAG.ToString()!;
                characterDisplayDTO = new GameCharacterDisplayDTO()
                {
                    ObjectId = objectId!,
                    DisplayCategory = category.ToString(),
                    DisplayName = characterModel.CHARACTER_NAME.ToString(),
                    DisplayDesc = $"{objectId}:{characterModel.STYLE_NAME}",

                };
                return true;

            }

        }
        public static IEnumerable<GameCharacterDisplayDTO> GetGameCharacterDisplays(this TstdGameEnvironment @this)
        {
            var team = @this.Ptr_TeamManager;

            var characters = team.CHARACTERS;
            if (characters.Valid())
            {
                foreach (var character in characters.AsEnumerable())
                {
                    if (character.TryGetGameCharacterDisplayImp(EnumGameCharacterType.CHARACTER, out var data))
                    {
                        yield return data;

                    }
                }
            }

            var tempCharacters = team.TEMP_CHARACTERS;
            if (tempCharacters.Valid())
            {
                foreach (var character in tempCharacters.AsEnumerable())
                {
                    if (character.TryGetGameCharacterDisplayImp(EnumGameCharacterType.TEMP, out var data))
                    {
                        yield return data;

                    }
                }
            }


            var alternateCharacters = team.ALTERNATE_CHARACTERS;
            if (alternateCharacters.Valid())
            {
                foreach (var character in alternateCharacters.AsEnumerable())
                {
                    if (character.TryGetGameCharacterDisplayImp(EnumGameCharacterType.ALTERNATE, out var data))
                    {
                        yield return data;

                    }
                }
            }

            var npcCharacters = team.NPC_CHARACTERS;
            if (npcCharacters.Valid())
            {
                foreach (var character in npcCharacters.AsEnumerable())
                {
                    if (character.TryGetGameCharacterDisplayImp(EnumGameCharacterType.NPC, out var data))
                    {
                        yield return data;

                    }
                }
            }

        }

        private static bool TryFindCharacter(this IEnumerable<Character.Ptr_Character> ptr_Characters, string tag, out Character.Ptr_Character ptr_Character)
        {
            Unsafe.SkipInit(out ptr_Character);
            foreach (var character in ptr_Characters)
            {
                var data = character._DATA;
                if (data.Valid() == false)
                {
                    continue;
                }
                if (tag.AsSpan().SequenceEqual(data.TAG.AsReadOnlySpan()))
                {
                    ptr_Character = character;
                    return true;
                }
            }
            return false;
        }
        private static bool TryFindCharacter(this TstdGameEnvironment @this, string tag, EnumGameCharacterType category, out Character.Ptr_Character ptr_Character)
        {
            Unsafe.SkipInit(out ptr_Character);

            var team = @this.Ptr_TeamManager;
            var characters = team.CHARACTERS;
            if (category == EnumGameCharacterType.CHARACTER && characters.Valid())
            {
                if (characters.AsEnumerable().TryFindCharacter(tag, out ptr_Character))
                {
                    return true;
                }
            }

            var tempCharacters = team.TEMP_CHARACTERS;
            if (category == EnumGameCharacterType.TEMP && tempCharacters.Valid())
            {
                if (characters.AsEnumerable().TryFindCharacter(tag, out ptr_Character))
                {
                    return true;
                }
            }


            var alternateCharacters = team.ALTERNATE_CHARACTERS;
            if (category == EnumGameCharacterType.ALTERNATE && alternateCharacters.Valid())
            {
                if (characters.AsEnumerable().TryFindCharacter(tag, out ptr_Character))
                {
                    return true;
                }
            }

            var npcCharacters = team.NPC_CHARACTERS;
            if (category == EnumGameCharacterType.NPC && npcCharacters.Valid())
            {
                if (characters.AsEnumerable().TryFindCharacter(tag, out ptr_Character))
                {
                    return true;
                }
            }
            return false;
        }
        private static IEnumerable<(StatType statType, int statValue)> GetGameCharacterStatusImp(this Character.Ptr_Character ptr_Character)
        {
            var state = ptr_Character._ADDED_STAT;
            if (state.Valid() == false)
            {
                yield break;
            }
            var stateDatas = state.STATS;
            if (stateDatas.Valid() == false)
            {
                yield break;
            }
            foreach (var data in stateDatas)
            {
                yield return (data.TYPE, data.VALUE);
            }
        }
        private static IEnumerable<GameSwitchDisplayDTO> EnumGameCharacterStatus(this Character.Ptr_Character ptr_Character)
        {
            var datas = ptr_Character.GetGameCharacterStatusImp().GroupBy(p => p.statType).ToDictionary(p => p.Key, p => p.Sum(x => x.statValue));
            foreach (var s in Enum.GetValues<StatType>())
            {
                if (!datas.TryGetValue(s, out var val))
                {
                    val = 0;
                }
                yield return new GameSwitchDisplayDTO()
                {
                    ObjectId = s.ToString(),
                    DisplayCategory = s.ToString(),
                    DisplayName = $"附加*{s}",
                    ContentValue = val.ToString(),
                    UIType = (int)EnumGameSwitchUIType.TextEditor,
                    CanWrite = true,
                };
            }
        }
        public static GameCharacterStatusDTO GetGameCharacterStatus(this TstdGameEnvironment @this, GameCharacterObjectDTO characterObjectDTO)
        {
            if (Enum.TryParse<EnumGameCharacterType>(characterObjectDTO.CharacterCategory, out var category))
            {
                if (@this.TryFindCharacter(characterObjectDTO.CharacterId, category, out var ptr_Character))
                {
                    return new GameCharacterStatusDTO() { ObjectId = characterObjectDTO.CharacterId, CharacterAttributes = [.. ptr_Character.EnumGameCharacterStatus()] };
                }
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND:{characterObjectDTO.CharacterId}");
        }

        private static void SetGameCharacterStatusImp(this Character.Ptr_Character ptr_Character, StatType statType, int statValue)
        {
            var state = ptr_Character._ADDED_STAT;
            if (state.Valid() == false)
            {
                return;
            }
            var stateDatas = state.STATS;
            if (stateDatas.Valid() == false)
            {
                return;
            }
            foreach (ref readonly var data in stateDatas.AsReadOnlySpan())
            {
                if (data.TYPE == statType)
                {
                    ref var ref_value = ref Unsafe.AsRef(in data);
                    ref_value.VALUE = statValue;
                    return;
                }
            }
            state.SET_ITEM_01(statType, statValue);
        }
        public static GameCharacterStatusDTO UpdateGameCharacterStatus(this TstdGameEnvironment @this, GameCharacterModifyDTO characterModifyDTO)
        {
            if (Enum.TryParse<EnumGameCharacterType>(characterModifyDTO.CharacterCategory, out var category)
                && Enum.TryParse<StatType>(characterModifyDTO.ModifyObject, out var statType))
            {
                if (@this.TryFindCharacter(characterModifyDTO.CharacterId, category, out var ptr_Character))
                {
                    ptr_Character.SetGameCharacterStatusImp(statType, characterModifyDTO.IntValue);
                    return new GameCharacterStatusDTO() { ObjectId = characterModifyDTO.CharacterId, CharacterAttributes = [.. ptr_Character.EnumGameCharacterStatus()] };
                }
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND:{characterModifyDTO.CharacterId}");
        }
    }

    public enum EnumGameCurrencyType
    {
        MONEY = 0,
        EXP = 1,
        LV = 2,
        MP = 3,
    }

    public enum EnumGameInventoryType
    {
        Character = 0,
        Equipment = 1,
        Consumable = 2,
        Item = 3,
    }

    public enum EnumGameCharacterType
    {
        CHARACTER = 0,
        ALTERNATE = 1,
        TEMP = 2,
        NPC = 3,
    }
}


