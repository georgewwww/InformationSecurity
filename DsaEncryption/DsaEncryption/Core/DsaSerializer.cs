using DJD.Security;
using DsaEncryption.Models;
using Newtonsoft.Json;
using System;
using System.Text;

namespace DsaEncryption.Core
{
    public static class DsaSerializer
    {
        public static string Serialize(Tuple<BigInteger, BigInteger> signTuple)
        {
            var tupleKey = new TupleKey {
                R = signTuple.Item1.ToString(),
                S = signTuple.Item2.ToString()
            };
            return JsonConvert.SerializeObject(tupleKey);
        }

        public static Tuple<BigInteger, BigInteger> Deserialize(string str)
        {
            var tupleKey = JsonConvert.DeserializeObject<TupleKey>(str);
            var key1 = new BigInteger(tupleKey.R, 10);
            var key2 = new BigInteger(tupleKey.S, 10);

            return new Tuple<BigInteger, BigInteger>(key1, key2);
        }
    }
}
