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
 
namespace Ca.Infoway.Messagebuilder.J5goodies {
	
	using Ca.Infoway.Messagebuilder;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	
	/// <summary>
	/// Find classes on the class path.
	/// </summary>
	///
	public class ClassFinder {
	
        /*
		public IList<Type> FindClasses(Type context, ClassPredicate predicate) {
			String resourceName = ToResourceName(context);
			String urlAsString = GetType().GetResource(resourceName).ToExternalForm();
			return GetFinder(urlAsString, context).Find(predicate);
		}
	
		public IList<Type> FindClasses(Uri pathToManifest,
				ClassPredicate predicate) {
			String urlAsString = pathToManifest.ToExternalForm();
			return GetFinder(urlAsString, "/META-INF/MANIFEST.MF").Find(predicate);
		}
        */
	
		private FinderStrategy GetFinder(String root, Type context) {
			if (IsJar(root)) {
				return new JarFinderStrategy(ExtractRoot(root, context));
			} else {
				return new DirectoryFinderStrategy(ExtractRoot(root, context));
			}
		}
	
		private FinderStrategy GetFinder(String root, String context) {
			if (IsJar(root)) {
				return new JarFinderStrategy(ExtractRoot(root, context));
			} else {
				return new DirectoryFinderStrategy(ExtractRoot(root, context));
			}
		}
	
		private bool IsJar(String urlAsString) {
			return urlAsString.Contains("!");
		}
	
		static internal String ExtractRoot(String path, Type mainClass) {
			return ExtractRoot(path, mainClass.FullName.Replace('.', '/'));
		}
	
		static internal String ExtractRoot(String path, String resourceName) {
			if (path.Contains("!")) {
				return Ca.Infoway.Messagebuilder.StringUtils.SubstringBefore(path, "!");
			} else if (path.Contains("/WEB-INF")) {
				return Ca.Infoway.Messagebuilder.StringUtils.SubstringBefore(path, "/WEB-INF");
			} else {
				return Ca.Infoway.Messagebuilder.StringUtils.SubstringBefore(path, resourceName);
			}
		}
	
		private String ToResourceName(Type mainClass) {
			return "/" + mainClass.FullName.Replace('.', '/') + ".class";
		}
	}
}
