/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetInvokeTxResponse : AbstractModel
    {
        
        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("TxValidationCode")]
        public long? TxValidationCode{ get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [JsonProperty("TxValidationMsg")]
        public string TxValidationMsg{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TxValidationCode", this.TxValidationCode);
            this.SetParamSimple(map, prefix + "TxValidationMsg", this.TxValidationMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

