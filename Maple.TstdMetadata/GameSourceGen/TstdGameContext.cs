using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.TstdMetadata
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]

    [MonoCollectorType(typeof(Inventorys))]
    [MonoCollectorType(typeof(ItemSlot))]
    [MonoCollectorType(typeof(Character))]
    [MonoCollectorType(typeof(ConsumableItem))]
    [MonoCollectorType(typeof(Equipment))]
    [MonoCollectorType(typeof(Item))]

    [MonoCollectorType(typeof(GameManager))]
    [MonoCollectorType(typeof(TeamManager))]



    [MonoCollectorType(typeof(ResourceManager))]
    [MonoCollectorType(typeof(TagResource))]


    [MonoCollectorType(typeof(CharacterModelData))]
    [MonoCollectorType(typeof(BaseCharacterData))]

    //[MonoCollectorType(typeof(ShopItemsData))]
    [MonoCollectorType(typeof(InGameResource))]
    [MonoCollectorType(typeof(SecureInt))]



    [MonoCollectorType(typeof(GeneralBuff))]
    [MonoCollectorType(typeof(GeneralBuffData))]


    [MonoCollectorType(typeof(StatList))]
    [MonoCollectorType(typeof(StatValue))]

    public partial class TstdGameContext
    {

    }
}
