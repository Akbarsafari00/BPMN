/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalUserTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalScriptTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalManualTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalBusinessRuleTask))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("globalTask", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class GlobalTask : CallableElement {
    
    private ResourceRole[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("performer", typeof(Performer))]
    [System.Xml.Serialization.XmlElementAttribute("resourceRole", typeof(ResourceRole))]
    public ResourceRole[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}