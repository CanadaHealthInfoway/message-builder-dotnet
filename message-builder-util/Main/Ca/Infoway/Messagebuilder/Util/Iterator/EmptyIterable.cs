/**
 * Copyright 2013 Canada Health Infoway, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Author:        $LastChangedBy: gng $
 * Last modified: $LastChangedDate: 2015-11-19 18:20:12 -0500 (Fri, 30 Jan 2015) $
 * Revision:      $LastChangedRevision: 9755 $
 */


/// ---------------------------------------------------------------------------------------------------
///  This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
///  Version 1.0.0                                                                                      
/// ---------------------------------------------------------------------------------------------------
 
namespace Ca.Infoway.Messagebuilder.Util.Iterator {
	
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// A utility that performs nullness checking on an iterable.  If an 
	/// iterable is null, then an empty iterable is returned, preventing a 
	/// NullPointerException.
	/// A typical use of this class is as follows:
	/// <c>
	/// import static ca.infoway.messagebuilder.util.iterator.EmptyIterable.nullSafeIterable;
	/// ...
	/// public void doMethod() {
	/// for (String text : nullSafeIterable(getTextCollection)) {
	/// ...
	/// }
	/// }
	/// ...
	/// </c>
	/// </summary>
	///
	public class EmptyIterable<T> : IEnumerable<T> {
		
		class Enumerator<T> : IEnumerator<T> {
			
			public T Current {
				get { return default(T); }
			}
			public void Dispose() {}

			object IEnumerator.Current
			{
				get { return default(object); }
			}

			public bool MoveNext()
			{
				return false;
			}
			
			public void Reset()
			{
			}
		}
		
		/// <summary>
		/// Check the incoming iterable type to see if it's null.
		/// </summary>
		///
		/// <param name="TO"> - the type of object to iterate over</param>
		/// <param name="i">- the iterable type that might be null</param>
		/// <returns>- the iterable types iterator if it's not null; an empty iterator otherwise</returns>
		public static IEnumerable<TO> NullSafeIterable<TO>(IEnumerable<TO> i) {
			return (i == null) ? (IEnumerable<TO>) (new EmptyIterable<TO>()) : (IEnumerable<TO>) (i);
		}
	
		/// <summary>
		/// Check the incoming array to see if it's null.
		/// </summary>
		///
		/// <param name="TE"> - the element type of the array</param>
		/// <param name="i">- the array that might be null</param>
		/// <returns>- an array iterator or an empty iterator</returns>
		public static IEnumerable<TE> NullSafeIterable<TE>(TE[] i) {
			return (i == null) ? (IEnumerable<TE>) (new EmptyIterable<TE>()) : (IEnumerable<TE>) (new ArrayIterable<TE>(i));
		}
	
		/// <summary>
		/// Check the incoming map to see if it's null.  If not, return the 
		/// keySet iterator, otherwise return an empty iterator.
		/// </summary>
		///
		/// <param name="K"> - the element type of the array</param>
		/// <param name="map">- the map that might be null</param>
		/// <returns>- the keyset iterator</returns>
		public static IEnumerable<K> NullSafeKeySetIterable<K,V>(IDictionary<K, V> map) {
			return (map == null) ? (IEnumerable<K>) (new EmptyIterable<K>()) : (IEnumerable<K>) (NullSafeIterable(new ILOG.J2CsMapping.Collections.Generics.ListSet<K>(map.Keys)));
		}
	
		/// <summary>
		/// Check the incoming map to see if it's null.  If not, return the 
		/// values iterator, otherwise return an empty iterator.
		/// </summary>
		///
		/// <param name="K"> - the element type of the array</param>
		/// <param name="map">- the map that might be null</param>
		/// <returns>- the values iterator</returns>
		public static IEnumerable<V> NullSafeValuesIterable<K,V>(IDictionary<K, V> map) {
			return (map == null) ? (IEnumerable<V>) (new EmptyIterable<V>()) : (IEnumerable<V>) (NullSafeIterable(map.Values));
		}

        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new Enumerator<T>();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<object>();
        }

        #endregion
    }
}
