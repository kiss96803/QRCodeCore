﻿//=================================================================================================
// Copyright 2016 Dirk Lemstra <https://github.com/dlemstra/QRCodeCore>
//
// Licensed under the Apache 2.0 License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   https://github.com/dlemstra/QRCodeCore/blob/master/License.txt
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

namespace QRCodeCore
{
  public sealed class QRCodeData
  {
    public QRCodeData(string text)
    {
      Text = text;
      EccLevel = EccLevel.Q;
    }

    public EccLevel EccLevel
    {
      get;
      set;
    }

    internal string Text
    {
      get;
      private set;
    }
  }
}
