//
// metadataType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
// MODIFIED 1/21/04 David Hodges to include LOM type
//


using System.Collections;
using System.Xml;
using imsmd = imsmd_rootv1p2p1;

namespace adlcp_rootv1p2.imscp
{
	public class metadataType : Altova.Node
	{
		#region Forward constructors
		public metadataType() : base() { SetCollectionParents(); }
		public metadataType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public metadataType(XmlNode node) : base(node) { SetCollectionParents(); }
		public metadataType(Altova.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{
			int nCount;

			nCount = DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			nCount = DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion", i);
				InternalAdjustPrefix(DOMNode, false);
			}
		}


		#region schema accessor methods
		public int GetschemaMinCount()
		{
			return 0;
		}

		public int schemaMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetschemaMaxCount()
		{
			return 1;
		}

		public int schemaMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetschemaCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema");
		}

		public int schemaCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema");
			}
		}

		public bool Hasschema()
		{
			return HasDomChild(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema");
		}

		public schemaType GetschemaAt(int index)
		{
			return new schemaType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema", index)));
		}

		public schemaType Getschema()
		{
			return GetschemaAt(0);
		}

		public schemaType schema
		{
			get
			{
				return GetschemaAt(0);
			}
		}

		public void RemoveschemaAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema", index);
		}

		public void Removeschema()
		{
			while (Hasschema())
				RemoveschemaAt(0);
		}

		public void Addschema(schemaType newValue)
		{
			AppendDomChild(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema", newValue.ToString());
		}

		public void InsertschemaAt(schemaType newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema", index, newValue.ToString());
		}

		public void ReplaceschemaAt(schemaType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schema", index, newValue.ToString());
		}
		#endregion // schema accessor methods

		#region schema collection
		public schemaCollection	Myschemas = new schemaCollection( );

		public class schemaCollection: IEnumerable
		{
			metadataType parent;
			public metadataType Parent
			{
				set
				{
					parent = value;
				}
			}
			public schemaEnumerator GetEnumerator() 
			{
				return new schemaEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
		}

		public class schemaEnumerator: IEnumerator 
		{
			int nIndex;
			metadataType parent;
			public schemaEnumerator(metadataType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.schemaCount );
			}
			public schemaType  Current 
			{
				get 
				{
					return(parent.GetschemaAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
		}
	
		#endregion // schema collection

		#region schemaversion accessor methods
		public int GetschemaversionMinCount()
		{
			return 0;
		}

		public int schemaversionMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetschemaversionMaxCount()
		{
			return 1;
		}

		public int schemaversionMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetschemaversionCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion");
		}

		public int schemaversionCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion");
			}
		}

		public bool Hasschemaversion()
		{
			return HasDomChild(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion");
		}

		public schemaversionType GetschemaversionAt(int index)
		{
			return new schemaversionType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion", index)));
		}

		public schemaversionType Getschemaversion()
		{
			return GetschemaversionAt(0);
		}

		public schemaversionType schemaversion
		{
			get
			{
				return GetschemaversionAt(0);
			}
		}

		public void RemoveschemaversionAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion", index);
		}

		public void Removeschemaversion()
		{
			while (Hasschemaversion())
				RemoveschemaversionAt(0);
		}

		public void Addschemaversion(schemaversionType newValue)
		{
			AppendDomChild(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion", newValue.ToString());
		}

		public void InsertschemaversionAt(schemaversionType newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion", index, newValue.ToString());
		}

		public void ReplaceschemaversionAt(schemaversionType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "schemaversion", index, newValue.ToString());
		}
		#endregion // schemaversion accessor methods

		#region schemaversion collection
		public schemaversionCollection	Myschemaversions = new schemaversionCollection( );

		public class schemaversionCollection: IEnumerable
		{
			metadataType parent;
			public metadataType Parent
			{
				set
				{
					parent = value;
				}
			}
			public schemaversionEnumerator GetEnumerator() 
			{
				return new schemaversionEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
		}

		public class schemaversionEnumerator: IEnumerator 
		{
			int nIndex;
			metadataType parent;
			public schemaversionEnumerator(metadataType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.schemaversionCount );
			}
			public schemaversionType  Current 
			{
				get 
				{
					return(parent.GetschemaversionAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
		}
	
		#endregion // schemaversion collection

		protected virtual void SetCollectionParents()
		{
			Myschemas.Parent = this; 
			Myschemaversions.Parent = this; 
		}
		// added by David Hodges 1/21/2004
		public bool HasLOM()
		{
			return HasDomChild(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "lom");
		}

		public imsmd.lomType GetLOMAt(int index)
		{
			return new imsmd.lomType(GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "lom", index));
		}

		public imsmd.lomType GetLOM()
		{
			return GetLOMAt(0);
		}

		public imsmd.lomType LOM
		{
			get
			{
				return GetLOMAt(0);
			}
		}
	}
}
