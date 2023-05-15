/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("globalUserTask", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class GlobalUserTask : GlobalTask {
    
    private Rendering[] renderingField;
    
    private string implementationField;
    
    public GlobalUserTask() {
        this.implementationField = "##unspecified";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("rendering")]
    public Rendering[] rendering {
        get {
            return this.renderingField;
        }
        set {
            this.renderingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("##unspecified")]
    public string implementation {
        get {
            return this.implementationField;
        }
        set {
            this.implementationField = value;
        }
    }
}