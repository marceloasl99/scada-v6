﻿/*
 * Copyright 2025 Rapid Software LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaWebCommon
 * Summary  : Specifies the known items of the main menu
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2016
 * Modified : 2021
 */

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member

namespace Scada.Web.TreeView
{
    /// <summary>
    /// Specifies the known items of the main menu.
    /// <para>Задает известные элементы главного меню.</para>
    /// </summary>
    public enum KnownMenuItem
    {
        None = 0,
        Reports = 1,
        Administration = 2,
        Configuration = 3,
        Registration = 4,
        Plugins = 5,
        About = 6
    }
}
