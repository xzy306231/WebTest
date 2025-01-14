﻿using System;
using System.Xml;

namespace Altova
{
    /// <summary>
    /// class Node
    /// </summary>
    public abstract class Node
    {
        public enum NodeType { Attribute, Element };
        protected internal XmlNode domNode;

        #region Constructors

        public Node()
        {
            domNode = Document.CreateTemporaryDomNode();
        }

        public Node(XmlDocument doc)
        {
            domNode = doc.DocumentElement;
        }

        public Node(XmlNode node)
        {
            domNode = node;
        }

        public Node(Node node)
        {
            domNode = node.domNode;
        }

        #endregion

        #region Utility methods

        public void MapPrefix(string prefix, string URI)
        {
            XmlElement element = (XmlElement)domNode;
            if (prefix == null || prefix == "")
                element.SetAttribute("xmlns", URI);
            else
                element.SetAttribute("xmlns:" + prefix, URI);
        }

        protected internal void DeclareNamespace(string prefix, string URI)
        {
            XmlElement root = domNode.OwnerDocument.DocumentElement;
            XmlAttributeCollection attrs = root.Attributes;
            if (attrs != null)
            {
                for (int i = 0; i < attrs.Count; i++)
                {
                    XmlAttribute attr = attrs[i];
                    if (attr.Value == URI) // namespace URI already mapped?
                        return; // do not overwrite
                }
            }
            if (prefix == null || prefix == "")
                root.SetAttribute("xmlns", URI);
            else
                root.SetAttribute("xmlns:" + prefix, URI);
        }

        protected static string GetDomNodeValue(XmlNode node)
        {
            return node.InnerText;
        }

        protected static void SetDomNodeValue(XmlNode node, string Value)
        {
            node.InnerText = Value;
        }

        protected XmlElement CloneDomElementAs(string URI, string name, Node node)
        {
            XmlElement srcElement = (XmlElement)node.domNode;
            XmlElement dstElement = domNode.OwnerDocument.CreateElement(name, URI);
            XmlDocument doc = domNode.OwnerDocument;

            foreach (XmlAttribute attribute in srcElement.Attributes)
                dstElement.Attributes.Append((XmlAttribute)doc.ImportNode(attribute, false));
            foreach (XmlNode childNode in srcElement.ChildNodes)
                dstElement.AppendChild(doc.ImportNode(childNode, true));
            return dstElement;
        }

        protected internal void MakeRoot(string namespaceURI, string rootElementName, string schemaLocation)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement(rootElementName, namespaceURI);

            doc.AppendChild(doc.CreateProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\""));
            doc.AppendChild(root);

            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            if (namespaceURI == null || namespaceURI == "")
            {
                if (schemaLocation != null && schemaLocation != "")
                {
                    XmlAttribute a = doc.CreateAttribute("xsi:noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
                    a.Value = schemaLocation;
                    root.SetAttributeNode(a);
                }
            }
            else
            {
                if (schemaLocation != null && schemaLocation != "")
                {
                    XmlAttribute a = doc.CreateAttribute("xsi:schemaLocation", "http://www.w3.org/2001/XMLSchema-instance");
                    a.Value = namespaceURI + " " + schemaLocation;
                    root.SetAttributeNode(a);
                }
            }

            foreach (XmlAttribute attribute in domNode.Attributes)
                root.Attributes.Append((XmlAttribute)doc.ImportNode(attribute, true));
            foreach (XmlNode childNode in domNode.ChildNodes)
                root.AppendChild(doc.ImportNode(childNode, true));

            domNode = root;
        }

        #endregion

        #region Child node manipulation methods

        public XmlNode getDOMNode()
        {
            return domNode;
        }

        protected bool HasDomChild(NodeType type, string URI, string name)
        {
            if (type == NodeType.Attribute)
            {
                foreach (XmlAttribute attribute in domNode.Attributes)
                    //if (attribute.NamespaceURI == URI && attribute.LocalName == name)
                    if (attribute.LocalName == name)
                        return true;
                return false;
            }
            else
            {
                foreach (XmlNode node in domNode.ChildNodes)
                    //if (node.NamespaceURI == URI && node.LocalName == name)
                    if (node.LocalName == name)
                        return true;
                return false;
            }
        }

        protected int DomChildCount(NodeType type, string URI, string name)
        {
            if (type == NodeType.Attribute)
            {
                foreach (XmlAttribute attribute in domNode.Attributes)
                    //if (attribute.NamespaceURI == URI && attribute.LocalName == name)
                    if (attribute.LocalName == name)
                        return 1;
                return 0;
            }
            else
            {
                int count = 0;
                foreach (XmlNode node in domNode.ChildNodes)
                    //if (node.NamespaceURI == URI && node.LocalName == name)
                    if (node.LocalName == name)
                        count++;
                return count;
            }
        }

        protected XmlNode AppendDomChild(NodeType type, string URI, string name, string Value)
        {
            if (type == NodeType.Attribute)
            {
                XmlAttribute attribute = domNode.OwnerDocument.CreateAttribute(name, URI);
                attribute.Value = Value;
                domNode.Attributes.Append(attribute);
                return attribute;
            }
            else
            {
                XmlElement element = domNode.OwnerDocument.CreateElement(name, URI);
                element.InnerText = Value;
                domNode.AppendChild(element);
                return element;
            }
        }

        protected XmlNode AppendDomElement(string URI, string name, Node node)
        {
            node.domNode = CloneDomElementAs(URI, name, node);
            return domNode.AppendChild(node.domNode);
        }

        protected XmlNode InsertDomChildAt(NodeType type, string URI, string name, int index, string Value)
        {
            if (type == NodeType.Attribute)
            {
                return AppendDomChild(type, URI, name, Value);
            }
            else
            {
                XmlElement element = domNode.OwnerDocument.CreateElement(name, URI);
                element.InnerText = Value;
                domNode.InsertBefore(element, GetDomChildAt(type, URI, name, index));
                return element;
            }
        }

        protected XmlNode InsertDomElementAt(string URI, string name, int index, Node node)
        {
            node.domNode = CloneDomElementAs(URI, name, node);
            return domNode.InsertBefore(node.domNode, GetDomChildAt(NodeType.Element, URI, name, index));
        }

        protected XmlNode GetDomChildAt(NodeType type, string URI, string name, int index)
        {
            if (type == NodeType.Attribute)
            {
                if (index > 0)
                    throw new Exception("Index out of range");
                foreach (XmlAttribute a in domNode.Attributes)
                    //if (a.NamespaceURI == URI && a.LocalName == name)
                    if (a.LocalName == name)
                        return a;
                throw new Exception("Not found");
            }
            else
            {
                int count = 0;
                foreach (XmlNode n in domNode.ChildNodes)
                    //if (n.NamespaceURI == URI && n.LocalName == name)
                    if (n.LocalName == name)
                        if (count++ == index)
                            return n;
                if (count > 0)
                    throw new Exception("Index out of range");
                else
                    throw new Exception("Not found");
            }
        }

        protected XmlNode ReplaceDomChildAt(NodeType type, string URI, string name, int index, string Value)
        {
            if (type == NodeType.Attribute)
            {
                XmlAttribute attr = domNode.OwnerDocument.CreateAttribute(name, URI);
                attr.Value = Value;
                return domNode.Attributes.Append(attr);
            }
            else
            {
                XmlElement elem = domNode.OwnerDocument.CreateElement(name, URI);
                elem.InnerText = Value;
                return domNode.ReplaceChild(elem, GetDomChildAt(type, URI, name, index));
            }
        }

        protected XmlNode ReplaceDomElementAt(string URI, string name, int index, Node node)
        {
            node.domNode = CloneDomElementAs(URI, name, node);
            return domNode.ReplaceChild(node.domNode, GetDomChildAt(NodeType.Element, URI, name, index));
        }

        protected XmlNode RemoveDomChildAt(NodeType type, string URI, string name, int index)
        {
            if (type == NodeType.Attribute)
            {
                return domNode.Attributes.RemoveNamedItem(name, URI);
            }
            else
            {
                return domNode.RemoveChild(GetDomChildAt(type, URI, name, index));
            }
        }

        protected static string LookupPrefix(XmlNode node, string URI)
        {
            if (node == null || URI == null || URI == "")
                return null;

            if (node.NodeType == XmlNodeType.Element)
            {
                XmlAttributeCollection attrs = node.Attributes;
                if (attrs != null)
                {
                    int len = attrs.Count;
                    for (int i = 0; i < len; i++)
                    {
                        XmlAttribute attr = attrs[i];
                        String name = attr.Name;
                        String value = attr.Value;
                        if (value != null && value == URI)
                        {
                            if (name.StartsWith("xmlns:"))
                                return name.Substring(6);
                            else
                                return null;
                        }
                    }
                }
                return LookupPrefix(node.ParentNode, URI);
            }
            else if (node.NodeType == XmlNodeType.Attribute)
            {
                return LookupPrefix(node.ParentNode, URI);
            }
            else
            {
                return null;
            }
        }

        protected internal static void InternalAdjustPrefix(XmlNode node, bool qualified)
        {
            if (node != null && qualified)
            {
                string prefix = LookupPrefix(node, node.NamespaceURI);
                if (prefix != null)
                    node.Prefix = prefix;
            }
        }

        public abstract void AdjustPrefix();

        #endregion
    }
}
