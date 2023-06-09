#nullable disable
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LabeledEdge))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BPMNEdge))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DI")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DI", IsNullable=false)]
public abstract partial class Edge : DiagramElement {
    
    private Point[] waypointField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("waypoint")]
    public Point[] waypoint {
        get {
            return this.waypointField;
        }
        set {
            this.waypointField = value;
        }
    }
}