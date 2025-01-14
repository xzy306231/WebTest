//
// contributeType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using adlcp_v1p3.Altova.Types;

namespace adlcp_v1p3.imsmd_rootv1p2p1
{
	public class contributeType : Altova.Node
	{
		#region Forward constructors
		public contributeType() : base() { SetCollectionParents(); }
		public contributeType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public contributeType(XmlNode node) : base(node) { SetCollectionParents(); }
		public contributeType(Altova.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{
			int nCount;

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role", i);
				InternalAdjustPrefix(DOMNode, true);
				new roleType(DOMNode).AdjustPrefix();
			}

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity", i);
				InternalAdjustPrefix(DOMNode, true);
				new centityType(DOMNode).AdjustPrefix();
			}

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date", i);
				InternalAdjustPrefix(DOMNode, true);
				new dateType(DOMNode).AdjustPrefix();
			}
		}


		#region role accessor methods
		public int GetroleMinCount()
		{
			return 1;
		}

		public int roleMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetroleMaxCount()
		{
			return 1;
		}

		public int roleMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetroleCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role");
		}

		public int roleCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role");
			}
		}

		public bool Hasrole()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role");
		}

		public roleType GetroleAt(int index)
		{
			return new roleType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role", index));
		}

		public roleType Getrole()
		{
			return GetroleAt(0);
		}

		public roleType role
		{
			get
			{
				return GetroleAt(0);
			}
		}

		public void RemoveroleAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role", index);
		}

		public void Removerole()
		{
			while (Hasrole())
				RemoveroleAt(0);
		}

		public void Addrole(roleType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role", newValue);
		}

		public void InsertroleAt(roleType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role", index, newValue);
		}

		public void ReplaceroleAt(roleType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "role", index, newValue);
		}
		#endregion // role accessor methods

		#region role collection
        public roleCollection	Myroles = new roleCollection( );

        public class roleCollection: IEnumerable
        {
            contributeType parent;
            public contributeType Parent
			{
				set
				{
					parent = value;
				}
			}
			public roleEnumerator GetEnumerator() 
			{
				return new roleEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class roleEnumerator: IEnumerator 
        {
			int nIndex;
			contributeType parent;
			public roleEnumerator(contributeType par) 
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
				return(nIndex < parent.roleCount );
			}
			public roleType  Current 
			{
				get 
				{
					return(parent.GetroleAt(nIndex));
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
	
        #endregion // role collection

		#region centity accessor methods
		public int GetcentityMinCount()
		{
			return 0;
		}

		public int centityMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetcentityMaxCount()
		{
			return Int32.MaxValue;
		}

		public int centityMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetcentityCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity");
		}

		public int centityCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity");
			}
		}

		public bool Hascentity()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity");
		}

		public centityType GetcentityAt(int index)
		{
			return new centityType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity", index));
		}

		public centityType Getcentity()
		{
			return GetcentityAt(0);
		}

		public centityType centity
		{
			get
			{
				return GetcentityAt(0);
			}
		}

		public void RemovecentityAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity", index);
		}

		public void Removecentity()
		{
			while (Hascentity())
				RemovecentityAt(0);
		}

		public void Addcentity(centityType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity", newValue);
		}

		public void InsertcentityAt(centityType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity", index, newValue);
		}

		public void ReplacecentityAt(centityType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "centity", index, newValue);
		}
		#endregion // centity accessor methods

		#region centity collection
        public centityCollection	Mycentitys = new centityCollection( );

        public class centityCollection: IEnumerable
        {
            contributeType parent;
            public contributeType Parent
			{
				set
				{
					parent = value;
				}
			}
			public centityEnumerator GetEnumerator() 
			{
				return new centityEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class centityEnumerator: IEnumerator 
        {
			int nIndex;
			contributeType parent;
			public centityEnumerator(contributeType par) 
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
				return(nIndex < parent.centityCount );
			}
			public centityType  Current 
			{
				get 
				{
					return(parent.GetcentityAt(nIndex));
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
	
        #endregion // centity collection

		#region date accessor methods
		public int GetdateMinCount()
		{
			return 0;
		}

		public int dateMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetdateMaxCount()
		{
			return 1;
		}

		public int dateMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetdateCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date");
		}

		public int dateCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date");
			}
		}

		public bool Hasdate()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date");
		}

		public dateType GetdateAt(int index)
		{
			return new dateType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date", index));
		}

		public dateType Getdate()
		{
			return GetdateAt(0);
		}

		public dateType date
		{
			get
			{
				return GetdateAt(0);
			}
		}

		public void RemovedateAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date", index);
		}

		public void Removedate()
		{
			while (Hasdate())
				RemovedateAt(0);
		}

		public void Adddate(dateType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date", newValue);
		}

		public void InsertdateAt(dateType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date", index, newValue);
		}

		public void ReplacedateAt(dateType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "date", index, newValue);
		}
		#endregion // date accessor methods

		#region date collection
        public dateCollection	Mydates = new dateCollection( );

        public class dateCollection: IEnumerable
        {
            contributeType parent;
            public contributeType Parent
			{
				set
				{
					parent = value;
				}
			}
			public dateEnumerator GetEnumerator() 
			{
				return new dateEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class dateEnumerator: IEnumerator 
        {
			int nIndex;
			contributeType parent;
			public dateEnumerator(contributeType par) 
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
				return(nIndex < parent.dateCount );
			}
			public dateType  Current 
			{
				get 
				{
					return(parent.GetdateAt(nIndex));
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
	
        #endregion // date collection

        private void SetCollectionParents()
        {
            Myroles.Parent = this; 
            Mycentitys.Parent = this; 
            Mydates.Parent = this; 
	}
}
}
