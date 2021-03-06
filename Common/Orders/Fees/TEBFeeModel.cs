﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using QuantConnect.Securities;

namespace QuantConnect.Orders.Fees
{
    /// <summary>
    /// Provides an order fee model that always returns the same order fee.
    /// </summary>
    public class TEBFeeModel : IFeeModel
    {
        private readonly decimal _fee;

        /// <summary>
        /// Initializes a new instance of the <see cref="TEBFeeModel"/> class with the specified <paramref name="fee"/>
        /// </summary>
        /// <param name="fee">The constant order fee used by the model</param>
        public TEBFeeModel(decimal fee)
        {
            _fee = Math.Abs(fee);
        }

        /// <summary>
        /// Returns the constant fee for the model
        /// </summary>
        /// <param name="security">The security matching the order</param>
        /// <param name="order">The order to compute fees for</param>
        /// <returns>The cost of the order in units of the account currency</returns>
        public decimal GetOrderFee(Security security, Order order)
        {
            return _fee;
        }
    }
}