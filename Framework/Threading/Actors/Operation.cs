﻿/*
 * Copyright (C) 2012-2013 CypherCore <http://github.com/organizations/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */﻿

using System;

namespace Framework.Threading.Actors
{
    [Serializable]
    public enum Operation : byte
    {
        /// <summary>
        /// Stop processing, but don't dispose (the Actor can continue processing again
        /// at any point).
        /// </summary>
        None,
        /// <summary>
        /// Continue processing.
        /// </summary>
        Continue,
        /// <summary>
        /// Stop processing and dispose the Actor.
        /// </summary>
        Dispose,
    }
}
