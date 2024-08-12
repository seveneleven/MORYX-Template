using Moryx.StateMachines;

namespace MyApplication.Resources.SomeResource.States
{
    internal abstract class StateBase : StateBase<SomeCell>
    {

        
        public StateBase(SomeCell context, StateMap stateMap) : base(context, stateMap)
        {
        }
    }
}
