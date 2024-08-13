using Moryx.StateMachines;

namespace MyApplication.Resources.SomeCell.States
{
    internal abstract class SpecificState : SomeStateBase
    {
        public SpecificState(SomeCell context, StateMap stateMap) : base(context, stateMap)
        {
        }
    }
}
