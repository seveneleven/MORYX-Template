using Moryx.StateMachines;

namespace MyApplication.Resources.SomeResource.States
{
    internal abstract class SpecificState : StateBase<SomeResource>
    {
        public SpecificState(SomeCell context, StateMap stateMap) : base(context, stateMap)
        {
        }
    }
}
