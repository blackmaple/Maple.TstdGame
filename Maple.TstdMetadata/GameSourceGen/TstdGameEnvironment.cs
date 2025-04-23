using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Maple.TstdMetadata
{
    public partial class TstdGameEnvironment(TstdGameContext context)
    {
        //Event.编所不能用
        //Event.0-编
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
        public static List<GameValueInfoDTO> CacheStat { get; } =
            [
                 new GameValueInfoDTO() { ObjectId = 00.ToString(), DisplayName = 00.ToString(), IntValue = 00 },
                 new GameValueInfoDTO() { ObjectId = 05.ToString(), DisplayName = 05.ToString(), IntValue = 05 },
                 new GameValueInfoDTO() { ObjectId = 10.ToString(), DisplayName = 10.ToString(), IntValue = 10 },
                 new GameValueInfoDTO() { ObjectId = 15.ToString(), DisplayName = 15.ToString(), IntValue = 15 },
                 new GameValueInfoDTO() { ObjectId = 20.ToString(), DisplayName = 20.ToString(), IntValue = 20 },
                 new GameValueInfoDTO() { ObjectId = 25.ToString(), DisplayName = 25.ToString(), IntValue = 25 },
                 new GameValueInfoDTO() { ObjectId = 30.ToString(), DisplayName = 30.ToString(), IntValue = 30 },


            ];
        public static List<GameValueInfoDTO> CacheHit { get; } =
            [
                 new GameValueInfoDTO() { ObjectId = 00.ToString(), DisplayName = 00.ToString(), IntValue = 00 },
                 new GameValueInfoDTO() { ObjectId = 05.ToString(), DisplayName = 05.ToString(), IntValue = 05 },
                 new GameValueInfoDTO() { ObjectId = 10.ToString(), DisplayName = 10.ToString(), IntValue = 10 },
                 new GameValueInfoDTO() { ObjectId = 15.ToString(), DisplayName = 15.ToString(), IntValue = 15 },
                 new GameValueInfoDTO() { ObjectId = 20.ToString(), DisplayName = 20.ToString(), IntValue = 20 },
                 new GameValueInfoDTO() { ObjectId = 25.ToString(), DisplayName = 25.ToString(), IntValue = 25 },
                 new GameValueInfoDTO() { ObjectId = 30.ToString(), DisplayName = 30.ToString(), IntValue = 30 },


            ];
        public static List<GameValueInfoDTO> CacheHp { get; } = [
                 new GameValueInfoDTO() { ObjectId = 000.ToString(), DisplayName = 000.ToString(), IntValue = 000 },
                 new GameValueInfoDTO() { ObjectId = 100.ToString(), DisplayName = 100.ToString(), IntValue = 100 },
                 new GameValueInfoDTO() { ObjectId = 200.ToString(), DisplayName = 200.ToString(), IntValue = 200 },
                 new GameValueInfoDTO() { ObjectId = 300.ToString(), DisplayName = 300.ToString(), IntValue = 300 },
                 new GameValueInfoDTO() { ObjectId = 400.ToString(), DisplayName = 400.ToString(), IntValue = 400 },
                 new GameValueInfoDTO() { ObjectId = 500.ToString(), DisplayName = 500.ToString(), IntValue = 500 },
                 new GameValueInfoDTO() { ObjectId = 600.ToString(), DisplayName = 600.ToString(), IntValue = 600 },


            ];
        public static List<GameValueInfoDTO> CacheRate { get; } = [
                 new GameValueInfoDTO() { ObjectId = 00.ToString(), DisplayName = 00.ToString(), IntValue = 00 },
                 new GameValueInfoDTO() { ObjectId = 05.ToString(), DisplayName = 05.ToString(), IntValue = 05 },
                 new GameValueInfoDTO() { ObjectId = 10.ToString(), DisplayName = 10.ToString(), IntValue = 10 },
                 new GameValueInfoDTO() { ObjectId = 15.ToString(), DisplayName = 15.ToString(), IntValue = 15 },
                 new GameValueInfoDTO() { ObjectId = 20.ToString(), DisplayName = 20.ToString(), IntValue = 20 },
                 new GameValueInfoDTO() { ObjectId = 25.ToString(), DisplayName = 25.ToString(), IntValue = 25 },
                 new GameValueInfoDTO() { ObjectId = 30.ToString(), DisplayName = 30.ToString(), IntValue = 30 },


            ];

        public static GameSwitchDisplayDTO[] CacheSwitches { get; } =
            [
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchCollection.功能_编所状态.ToString(), DisplayName =EnumGameSwitchCollection.功能_编所状态.ToString(), UIType=(int)EnumGameSwitchUIType.Button  },
                new GameSwitchDisplayDTO(){ ObjectId = EnumGameSwitchCollection.功能_遇敌状态.ToString(), DisplayName =EnumGameSwitchCollection.功能_遇敌状态.ToString(),SwitchValue = false, IntCache =0, UIType=(int)EnumGameSwitchUIType.Switches  },

                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.兵.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.兵}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheHp    },

                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.攻.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.攻}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheStat   },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.智.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.智}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheStat  },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.武.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.武}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheStat  },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.速.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.速}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheStat  },

                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.暴击伤害.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.暴击伤害}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheHit   },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.计策增伤.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.计策增伤}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheHit   },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.计策防御.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.计策防御}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheHit    },

                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.暴击率.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.暴击率}",UIntContent = 0,UIType=(int)EnumGameSwitchUIType.Selects,SelectedContents=CacheRate  },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.闪避.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.闪避}",UIntContent = 0,UIType=   (int)EnumGameSwitchUIType.Selects,SelectedContents=CacheRate  },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.命中.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.命中}",UIntContent = 0,UIType=   (int)EnumGameSwitchUIType.Selects,SelectedContents=CacheRate  },
                new GameSwitchDisplayDTO(){DisplayDesc = "添加的装备自动强化该属性", ObjectId = EnumGameEquipmentEntrys.神算.ToString(), DisplayName =$"装备强化_{EnumGameEquipmentEntrys.神算}",UIntContent = 0,UIType=   (int)EnumGameSwitchUIType.Selects,SelectedContents=CacheRate  },

            ];

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

        static IEnumerable<string> GetEquipmentEntrys()
        {
            foreach (var switchData in CacheSwitches)
            {
                var cache = switchData.IntCache;
                if (cache > 0 && Enum.TryParse<EnumGameEquipmentEntrys>(switchData.ObjectId, out var equipmentEntrys))
                {
                    yield return $"{equipmentEntrys}:{cache}";
                }
            }

        }

        public Item.Ptr_Item NewItem(string id)
        {
            var tagId = Context.T2(id);
            return Item.Ptr_Item.LOAD_ITEM(tagId, nint.Zero);
        }
        public Equipment.Ptr_Equipment NewEquipment(string id)
        {
            var att = string.Join(',', GetEquipmentEntrys());
            var entrys = Context.T2(att);

            var tagId = Context.T2(id);
            return Item.Ptr_Item.LOAD_EQUIPMENT(tagId, entrys);
        }
        public Character.Ptr_Character NewCharacter(string id)
        {
            var tagId = Context.T2(id);
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

        static bool TryFindCharacter(this IEnumerable<Character.Ptr_Character> ptr_Characters, string tag, out Character.Ptr_Character ptr_Character)
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
        static bool TryFindCharacter(this TstdGameEnvironment @this, string tag, EnumGameCharacterType category, out Character.Ptr_Character ptr_Character)
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
                if (tempCharacters.AsEnumerable().TryFindCharacter(tag, out ptr_Character))
                {
                    return true;
                }
            }


            var alternateCharacters = team.ALTERNATE_CHARACTERS;
            if (category == EnumGameCharacterType.ALTERNATE && alternateCharacters.Valid())
            {
                if (alternateCharacters.AsEnumerable().TryFindCharacter(tag, out ptr_Character))
                {
                    return true;
                }
            }

            var npcCharacters = team.NPC_CHARACTERS;
            if (category == EnumGameCharacterType.NPC && npcCharacters.Valid())
            {
                if (npcCharacters.AsEnumerable().TryFindCharacter(tag, out ptr_Character))
                {
                    return true;
                }
            }
            return false;
        }


        static IEnumerable<GameSwitchDisplayDTO> GetGameCharacterStatusImp(this TstdGameEnvironment @this, Character.Ptr_Character ptr_Character)
        {
            var data = ptr_Character._DATA;
            if (data.Valid() == false)
            {
                yield break;
            }
            var tag = data.TAG;
            foreach (var s in Enum.GetValues<StatType>())
            {
                var val = @this.Ptr_GameManager.GET_ADD_STAT(tag, s);
                yield return new GameSwitchDisplayDTO()
                {
                    ObjectId = s.ToString(),
                    DisplayCategory = s.ToString(),
                    DisplayName = $"强化*{s}",
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
                    return new GameCharacterStatusDTO() { ObjectId = characterObjectDTO.CharacterId, CharacterAttributes = [.. @this.GetGameCharacterStatusImp(ptr_Character)] };
                }
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND:{characterObjectDTO.CharacterId}");
        }


        private static void SetGameCharacterStatusImp(this TstdGameEnvironment @this, Character.Ptr_Character ptr_Character, StatType statType, int statValue)
        {

            var data = ptr_Character._DATA;
            if (data.Valid() == false)
            {
                return;
            }

            var stat = @this.Ptr_GameManager.ADD_STAT;
            if (false == stat.Valid())
            {
                return;
            }

            @this.Ptr_GameManager.ADD_STAT_01(ptr_Character, statType, -1);

            var tag = data.TAG.AsReadOnlySpan();
            foreach (var saveStat in stat.DATAS)
            {
                if (saveStat.ID.AsReadOnlySpan().SequenceEqual(tag))
                {
                    var statData = saveStat.ADD_STAT;
                    foreach (ref readonly var s in statData.STATS.AsReadOnlySpan())
                    {
                        if (s.TYPE == statType)
                        {
                            ref var ref_val = ref Unsafe.AsRef(in s);
                            ref_val.VALUE = statValue;
                        }
                    }
                }
            }
        }
        public static GameCharacterStatusDTO UpdateGameCharacterStatus(this TstdGameEnvironment @this, GameCharacterModifyDTO characterModifyDTO)
        {
            if (Enum.TryParse<EnumGameCharacterType>(characterModifyDTO.CharacterCategory, out var category)
                && Enum.TryParse<StatType>(characterModifyDTO.ModifyObject, out var statType))
            {
                if (@this.TryFindCharacter(characterModifyDTO.CharacterId, category, out var ptr_Character))
                {
                    @this.SetGameCharacterStatusImp(ptr_Character, statType, characterModifyDTO.IntValue);
                    return new GameCharacterStatusDTO() { ObjectId = characterModifyDTO.CharacterId, CharacterAttributes = [.. @this.GetGameCharacterStatusImp(ptr_Character)] };
                }
            }
            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND:{characterModifyDTO.CharacterId}");
        }



        public static GameSwitchDisplayDTO UpdateGameSwitchDisplay(this TstdGameEnvironment @this, GameSwitchModifyDTO switchModifyDTO)
        {
            var switchData = TstdGameEnvironment.CacheSwitches.FirstOrDefault(p => p.ObjectId == switchModifyDTO.SwitchObjectId);
            if (switchData is not null)
            {

                if (Enum.TryParse<EnumGameEquipmentEntrys>(switchModifyDTO.SwitchObjectId, out var _))
                {

                }
                else if (Enum.TryParse<EnumGameSwitchCollection>(switchModifyDTO.SwitchObjectId, out var result))
                {
                    if (result == EnumGameSwitchCollection.功能_遇敌状态)
                    {
                        var ptr_team = @this.Ptr_TeamManager;
                        if (switchModifyDTO.SwitchValue)
                        {

                            ptr_team.AVOID_ENEMY_STEPS = int.MaxValue;
                        }
                        else
                        {
                            ptr_team.AVOID_ENEMY_STEPS = 0;
                        }
                    }
                    else if (result == EnumGameSwitchCollection.功能_编所状态)
                    {
                        @this.Ptr_GameManager.SET_EVENT_KEY(@this.Context.T2("Event.编所不能用"), 1);
                    }
                }

                switchData.CacheValue = switchModifyDTO.ContentValue;
                switchData.ContentValue = switchModifyDTO.ContentValue;
                return switchData;
            }


            return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND:{switchModifyDTO.SwitchObjectId}");
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


    /*
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
     
     */
    public enum EnumGameSwitchCollection
    {
        功能_遇敌状态 = 1,
        功能_编所状态 = 2,



    }

    public enum EnumGameEquipmentEntrys
    {
        攻 = 100,
        兵,
        智,
        武,
        速,
        暴击率,
        暴击伤害,
        计策增伤,
        计策防御,
        闪避,
        命中,
        神算,
    }
}


