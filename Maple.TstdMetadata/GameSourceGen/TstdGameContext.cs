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

    [MonoCollectorType(typeof(Character))]
    [MonoCollectorType(typeof(ConsumableItem))]
    [MonoCollectorType(typeof(Equipment))]
    [MonoCollectorType(typeof(Inventorys))]
    [MonoCollectorType(typeof(Item))]
    [MonoCollectorType(typeof(GameManager))]
    [MonoCollectorType(typeof(TeamManager))]



    [MonoCollectorType(typeof(ResourceManager))]
    [MonoCollectorType(typeof(TagResource))]
    public partial class TstdGameContext
    {

    }
}
