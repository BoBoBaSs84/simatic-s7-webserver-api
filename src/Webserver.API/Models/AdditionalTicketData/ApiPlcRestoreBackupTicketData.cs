﻿// Copyright (c) 2025, Siemens AG
//
// SPDX-License-Identifier: MIT
using Newtonsoft.Json;
using System;

namespace Siemens.Simatic.S7.Webserver.API.Models.AdditionalTicketData
{
    /// <summary>
    /// TBD!
    /// </summary>
    public class ApiPlcRestoreBackupTicketData
    {
        /// <summary>
        /// TBD!
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public ApiPlcRestoreBackupTicketData()
        {
            throw new NotImplementedException("!!");
        }

        /// <summary>
        /// Return the Json serialized object
        /// </summary>
        /// <returns>Json serialized object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
