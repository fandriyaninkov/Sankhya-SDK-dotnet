﻿// ***********************************************************************
// Assembly         : Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="InventoryType.cs" company="Guilherme Branco Stracini">
//     © 2023 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Sankhya.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// Enum InventoryType
    /// </summary>
    public enum InventoryType
    {

        /// <summary>
        /// The own
        /// </summary>
        [HumanReadable("Próprio")]
        [InternalValue("P")]
        Own,

        /// <summary>
        /// The third
        /// </summary>
        [HumanReadable("Terceiro")]
        [InternalValue("T")]
        Third
    }
}
