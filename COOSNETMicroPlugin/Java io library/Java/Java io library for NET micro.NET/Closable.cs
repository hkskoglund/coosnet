﻿/* Licensed to the Apache Software Foundation (ASF) under one or more
* contributor license agreements.  See the NOTICE file distributed with
* this work for additional information regarding copyright ownership.
* The ASF licenses this file to You under the Apache License, Version 2.0
* (the "License"); you may not use this file except in compliance with
* the License.  You may obtain a copy of the License at
* 
*     http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
using System;
namespace java.io
{
	
	/// <summary> Defines an interface for classes that can (or need to) be closed once they
	/// are not used any longer. This usually includes all sorts of
	/// {@link InputStream}s and {@link OutputStream}s. Calling the {@code close}
	/// method releases resources that the object holds.
	/// </summary>
	public interface Closeable
	{
		
		/// <summary> Closes the object and release any system resources it holds. If the
		/// object has already been closed, then invoking this method has no effect.
		/// 
		/// </summary>
		/// <throws>  IOException </throws>
		/// <summary>             if any error occurs when closing the object.
		/// </summary>
		void  close();
	}
}