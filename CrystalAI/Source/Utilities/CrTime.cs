﻿// GPL v3 License
// 
// Copyright (c) 2016-2017 Bismur Studios Ltd.
// Copyright (c) 2016-2017 Ioannis Giagkiozis
// 
// CrTime.cs is part of Crystal AI.
//  
// Crystal AI is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// Crystal AI is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Crystal AI.  If not, see <http://www.gnu.org/licenses/>.
using System.Diagnostics;


namespace Crystal {

  /// <summary>
  /// Clock.
  /// </summary>
  public static class CrTime {
    static readonly Stopwatch Clock;

    /// <summary>
    ///   The time in seconds since the start of the game.
    /// </summary>
    public static float TotalSeconds {
      get { return (float)Clock.Elapsed.TotalSeconds; }
    }

    /// <summary>
    /// The time in milliseconds since the start of the game.
    /// </summary>
    /// <value>
    /// The milliseconds.
    /// </value>
    public static float TotalMilliseconds {
      get { return (float)Clock.Elapsed.TotalMilliseconds; }
    }

    /// <summary>
    /// Initializes the <see cref="CrTime"/> class.
    /// </summary>
    static CrTime() {
      Clock = new Stopwatch();
      Clock.Start();
    }
  }

}