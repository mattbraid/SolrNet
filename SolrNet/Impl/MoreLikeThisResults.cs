﻿#region license
// Copyright (c) 2007-2010 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System.Collections;
using System.Collections.Generic;

namespace SolrNet.Impl {
    /// <summary>
    /// more-like-this query results
    /// </summary>
    public class MoreLikeThisResults<T>
    {
        public MoreLikeThisResults()
        {
            this.InterestingTermDetails = new Dictionary<string, float>();
            this.InterestingTermList = new List<string>();
        }

        public int NumFound { get; set; }

        public double? MaxScore { get; set; }

        public T Match { get; set; }

        public IDictionary<string, float> InterestingTermDetails { get; set; }

        public IList<string> InterestingTermList { get; set; }
    }
}