//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebuggingEntity {

    public SomeOtherClassComponent someOtherClass { get { return (SomeOtherClassComponent)GetComponent(VisualDebuggingComponentsLookup.SomeOtherClass); } }
    public bool hasSomeOtherClass { get { return HasComponent(VisualDebuggingComponentsLookup.SomeOtherClass); } }

    public void AddSomeOtherClass(SomeNamespace.SomeOtherClass newValue) {
        var component = CreateComponent<SomeOtherClassComponent>(VisualDebuggingComponentsLookup.SomeOtherClass);
        component.value = newValue;
        AddComponent(VisualDebuggingComponentsLookup.SomeOtherClass, component);
    }

    public void ReplaceSomeOtherClass(SomeNamespace.SomeOtherClass newValue) {
        var component = CreateComponent<SomeOtherClassComponent>(VisualDebuggingComponentsLookup.SomeOtherClass);
        component.value = newValue;
        ReplaceComponent(VisualDebuggingComponentsLookup.SomeOtherClass, component);
    }

    public void RemoveSomeOtherClass() {
        RemoveComponent(VisualDebuggingComponentsLookup.SomeOtherClass);
    }
}