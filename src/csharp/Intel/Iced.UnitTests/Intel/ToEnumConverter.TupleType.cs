/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if DECODER || ENCODER
using System;
using System.Collections.Generic;
using Iced.Intel;

namespace Iced.UnitTests.Intel {
	static partial class ToEnumConverter {
		public static bool TryTupleType(string value, out TupleType tupleType) => tupleTypeDict.TryGetValue(value, out tupleType);
		public static TupleType GetTupleType(string value) => TryTupleType(value, out var tupleType) ? tupleType : throw new InvalidOperationException($"Invalid TupleType value: {value}");

		static readonly Dictionary<string, TupleType> tupleTypeDict =
			// GENERATOR-BEGIN: TupleTypeHash
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			new Dictionary<string, TupleType>(34, StringComparer.Ordinal) {
				{ "None", TupleType.None },
				{ "Full_128", TupleType.Full_128 },
				{ "Full_256", TupleType.Full_256 },
				{ "Full_512", TupleType.Full_512 },
				{ "Half_128", TupleType.Half_128 },
				{ "Half_256", TupleType.Half_256 },
				{ "Half_512", TupleType.Half_512 },
				{ "Full_Mem_128", TupleType.Full_Mem_128 },
				{ "Full_Mem_256", TupleType.Full_Mem_256 },
				{ "Full_Mem_512", TupleType.Full_Mem_512 },
				{ "Tuple1_Scalar", TupleType.Tuple1_Scalar },
				{ "Tuple1_Scalar_1", TupleType.Tuple1_Scalar_1 },
				{ "Tuple1_Scalar_2", TupleType.Tuple1_Scalar_2 },
				{ "Tuple1_Scalar_4", TupleType.Tuple1_Scalar_4 },
				{ "Tuple1_Scalar_8", TupleType.Tuple1_Scalar_8 },
				{ "Tuple1_Fixed_4", TupleType.Tuple1_Fixed_4 },
				{ "Tuple1_Fixed_8", TupleType.Tuple1_Fixed_8 },
				{ "Tuple2", TupleType.Tuple2 },
				{ "Tuple4", TupleType.Tuple4 },
				{ "Tuple8", TupleType.Tuple8 },
				{ "Tuple1_4X", TupleType.Tuple1_4X },
				{ "Half_Mem_128", TupleType.Half_Mem_128 },
				{ "Half_Mem_256", TupleType.Half_Mem_256 },
				{ "Half_Mem_512", TupleType.Half_Mem_512 },
				{ "Quarter_Mem_128", TupleType.Quarter_Mem_128 },
				{ "Quarter_Mem_256", TupleType.Quarter_Mem_256 },
				{ "Quarter_Mem_512", TupleType.Quarter_Mem_512 },
				{ "Eighth_Mem_128", TupleType.Eighth_Mem_128 },
				{ "Eighth_Mem_256", TupleType.Eighth_Mem_256 },
				{ "Eighth_Mem_512", TupleType.Eighth_Mem_512 },
				{ "Mem128", TupleType.Mem128 },
				{ "MOVDDUP_128", TupleType.MOVDDUP_128 },
				{ "MOVDDUP_256", TupleType.MOVDDUP_256 },
				{ "MOVDDUP_512", TupleType.MOVDDUP_512 },
			};
			// GENERATOR-END: TupleTypeHash
	}
}
#endif