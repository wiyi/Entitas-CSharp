//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class TestMatcher {

    static IMatcher<TestEntity> _matcherTest2Context;

    public static IMatcher<TestEntity> Test2Context {
        get {
            if(_matcherTest2Context == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentsLookup.Test2Context);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherTest2Context = matcher;
            }

            return _matcherTest2Context;
        }
    }
}