﻿using System;
using System.Xml;

namespace adlcp_v1p3.Altova
{
    public abstract class Document
    {
        protected static XmlDocument tmpDocument = null;
        protected static XmlDocumentFragment tmpFragment = null;
        protected static int tmpNameCounter = 0;

        protected static XmlDocument GetTemporaryDocument()
        {
            if (tmpDocument == null)
                tmpDocument = new XmlDocument();
            return tmpDocument;
        }

        public static XmlNode CreateTemporaryDomNode()
        {
            string tmpName = "_" + tmpNameCounter++;
            if (tmpFragment == null)
            {
                tmpFragment = GetTemporaryDocument().CreateDocumentFragment();
                tmpDocument.AppendChild(tmpFragment);
            }

            XmlNode node = GetTemporaryDocument().CreateElement(tmpName);
            tmpFragment.AppendChild(node);
            return node;
        }

        protected string rootElementName = null;
        protected string namespaceURI = null;
        protected string schemaLocation = null;

        public Document()
        {

        }

        public void SetRootElementName(string namespaceURI, string rootElementName)
        {
            this.namespaceURI = namespaceURI;
            this.rootElementName = rootElementName;
        }

        public void SetSchemaLocation(string schemaLocation)
        {
            this.schemaLocation = schemaLocation;
        }

        public XmlNode Load(XmlReader reader)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            return doc.DocumentElement;
        }

        public XmlNode Load(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            return doc.DocumentElement;
        }

        public void Save(string filename, Node node)
        {
            FinalizeRootElement(node);
            Node.InternalAdjustPrefix(node.domNode, true);
            node.AdjustPrefix();
            node.domNode.OwnerDocument.Save(filename);
        }

        abstract protected void DeclareNamespaces(Node node);

        protected void DeclareNamespace(Node node, string prefix, string URI)
        {
            node.DeclareNamespace(prefix, URI);
        }

        protected void FinalizeRootElement(Node node)
        {
            if (node.domNode.ParentNode.NodeType != XmlNodeType.DocumentFragment)
                return;

            if (rootElementName == null || rootElementName == "")
                throw new Exception("Call SetRootElementName first");

            node.MakeRoot(namespaceURI, rootElementName, schemaLocation);
            DeclareNamespaces(node);
        }
    }
}
