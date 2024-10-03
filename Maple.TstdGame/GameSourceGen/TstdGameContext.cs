using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.TstdGame.GameSourceGen
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]

    [MonoCollectorType(typeof(ResourceManager))]
    [MonoCollectorType(typeof(TagResource))]
    internal partial class TstdGameContext
    {

    }
}
