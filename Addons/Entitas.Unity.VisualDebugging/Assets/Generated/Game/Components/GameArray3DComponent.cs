//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Array3DComponent array3D { get { return (Array3DComponent)GetComponent(GameComponentsLookup.Array3D); } }
    public bool hasArray3D { get { return HasComponent(GameComponentsLookup.Array3D); } }

    public void AddArray3D(string[,,] newArray3d) {
        var component = CreateComponent<Array3DComponent>(GameComponentsLookup.Array3D);
        component.array3d = newArray3d;
        AddComponent(GameComponentsLookup.Array3D, component);
    }

    public void ReplaceArray3D(string[,,] newArray3d) {
        var component = CreateComponent<Array3DComponent>(GameComponentsLookup.Array3D);
        component.array3d = newArray3d;
        ReplaceComponent(GameComponentsLookup.Array3D, component);
    }

    public void RemoveArray3D() {
        RemoveComponent(GameComponentsLookup.Array3D);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherArray3D;

    public static Entitas.IMatcher<GameEntity> Array3D {
        get {
            if(_matcherArray3D == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Array3D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherArray3D = matcher;
            }

            return _matcherArray3D;
        }
    }
}