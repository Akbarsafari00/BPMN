/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("subConversation", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class SubConversation : ConversationNode {
    
    private ConversationNode[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("callConversation", typeof(CallConversation))]
    [System.Xml.Serialization.XmlElementAttribute("conversation", typeof(Conversation))]
    [System.Xml.Serialization.XmlElementAttribute("conversationNode", typeof(ConversationNode))]
    [System.Xml.Serialization.XmlElementAttribute("subConversation", typeof(SubConversation))]
    public ConversationNode[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}