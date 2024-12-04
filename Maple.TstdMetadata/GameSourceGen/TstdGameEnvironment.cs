using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using static Maple.TstdMetadata.Character;
using static Maple.TstdMetadata.ItemSlot;

namespace Maple.TstdMetadata
{
    public partial class TstdGameEnvironment(TstdGameContext context)
    {
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
            return Item.Ptr_Item.LOAD_ITEM(tagId);
        }
        public Equipment.Ptr_Equipment NewEquipment(string id)
        {
            using var tagId = Context.T2(id);
            return Item.Ptr_Item.LOAD_EQUIPMENT(tagId);
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

        static void InitResource(this TstdGameEnvironment @this)
        {
            using var tagId = @this.Context.T2("maple");
            _ = Character.Ptr_Character.LOAD_PLAYER_CHARACTER(tagId);
            _ = Item.Ptr_Item.LOAD_EQUIPMENT(tagId);
            _ = Item.Ptr_Item.LOAD_ITEM(tagId);
        }
        public static void LoadResourceDataIfThrowNotInit(this TstdGameEnvironment @this)
        {
            var resources = @this.ResourceManager._DICTIONARY4;
            if (false == resources.Valid())
            {
                GameException.Throw("NOT INIT:ResourceManager");
            }

            @this.InitResource();
            foreach (var resource in resources.AsRefArray())
            {
                var span_key = resource.Key.AsReadOnlySpan();
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
                                DisplayDesc = pCharacter.STYLE_NAME.ToString(),
                            });
                            @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_PlayerCharacters, objectId);

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
                        var pItem = Item.Ptr_Item.LOAD_EQUIPMENT(tagId);
                        if (pItem)
                        {

                            TstdGameEnvironment.CacheEquipment.Add(new GameInventoryDisplayDTO()
                            {
                                ObjectId = objectId,
                                DisplayCategory = EnumGameInventoryType.Equipment.ToString(),
                                DisplayName = pItem.ITEM_NAME.ToString(),
                                DisplayDesc = pItem.DESC.ToString(),
                            });
                            @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_Equipments, objectId);

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
                        var pItem = Item.Ptr_Item.LOAD_ITEM(tagId);
                        if (pItem)
                        {

                            TstdGameEnvironment.CacheConsumables.Add(new GameInventoryDisplayDTO()
                            {
                                ObjectId = objectId,
                                DisplayCategory = EnumGameInventoryType.Consumable.ToString(),
                                DisplayName = pItem.ITEM_NAME.ToString(),
                                DisplayDesc = pItem.DESC.ToString(),
                            });
                            @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_Consumables, objectId);

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
                        var pItem = Item.Ptr_Item.LOAD_ITEM(tagId);
                        if (pItem)
                        {

                            TstdGameEnvironment.CacheItems.Add(new GameInventoryDisplayDTO()
                            {
                                ObjectId = objectId,
                                DisplayCategory = EnumGameInventoryType.Item.ToString(),
                                DisplayName = pItem.ITEM_NAME.ToString(),
                                DisplayDesc = pItem.DESC.ToString(),
                            });
                            @this.Logger.LogInformation("{key}-{tag}", ResourceModule.ResourceModule_Items, objectId);

                        }


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
                EnumGameCurrencyType.LV => new GameCurrencyInfoDTO() { ObjectId = currencyType.ToString(), DisplayValue = SecureInt.Ptr_SecureInt.DECRYPT(@this.Ptr_TeamManager.LV.encryptedValue).ToString() },
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
}


