﻿/*
 * Copyright (C) 2018 Nils277 (https://github.com/Nils277)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace KerbetrotterTools
{
    /// <summary>
    /// Interface for a listener for changes of the resources
    /// </summary>
    public interface IResourceChangeListener
    {
        /// <summary>
        /// Methode called on the listener that a resource has changed
        /// </summary>
        /// <param name="name">The name of the new resource configuration</param>
        void onResourceChanged(string name);
    }
}
