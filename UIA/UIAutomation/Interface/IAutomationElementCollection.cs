﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 11/6/2013
 * Time: 2:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    extern alias UIANET;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows.Automation;
    
    public interface IUiEltCollection : ICollection, IEnumerable, IDisposable
	{
		void CopyTo(Array array, int index);
		void CopyTo(AutomationElement[] array, int index);
		IEnumerator GetEnumerator();
		//AutomationElement Item { get; }
		int Count { get; }
		object SyncRoot { get; }
		bool IsSynchronized { get; }
		
		void Dispose();
		
		//AutomationElementCollection SourceCollection { get; set; }
		//AutomationElementCollection SourceCollection { get; }
		//IUiEltCollection SourceCollection { get; }
		List<IUiElement> SourceCollection { get; }
	}
}