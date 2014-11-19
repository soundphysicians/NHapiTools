using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Message;
using NHapi.Model.V24.Segment;
using NHapi.Model.V24.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V24.Group
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class GroupExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get IN3 Records from ADR_A19_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADR_A19_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADR_A19_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADR_A19_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from ADR_A19_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADR_A19_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADR_A19_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADR_A19_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from ADR_A19_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADR_A19_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADR_A19_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADR_A19_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NK1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNK1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get ROL2 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetROL2Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("ROL2RepetitionsUsed", "GetROL2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL2 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ROL> GetAllROL2Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ROL>("ROL2RepetitionsUsed", "GetROL2");
        }

        /// <summary>
        /// Get DB1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetDB1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetAL1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetDG1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get PROCEDURE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ADR_A19_PROCEDURE> GetAllPROCEDURERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ADR_A19_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Get GT1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetGT1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get INSURANCE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ADR_A19_INSURANCE> GetAllINSURANCERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ADR_A19_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get IN3 Records from ADT_A01_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A01_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A01_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A01_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from ADT_A01_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A01_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A01_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A01_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from ADT_A01_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A01_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A01_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A01_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from ADT_A03_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A03_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A03_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A03_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get IN3 Records from ADT_A05_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A05_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A05_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A05_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from ADT_A05_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A05_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A05_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A05_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from ADT_A05_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A05_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A05_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A05_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get IN3 Records from ADT_A06_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A06_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A06_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A06_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from ADT_A06_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A06_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A06_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A06_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from ADT_A06_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A06_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A06_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A06_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get IN3 Records from BAR_P01_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this BAR_P01_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from BAR_P01_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this BAR_P01_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from BAR_P01_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from BAR_P01_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01_VISIT
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get DB1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetOBXRecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from BAR_P01_VISIT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get PROCEDURE Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from BAR_P01_VISIT
        /// </summary>
        public static List<BAR_P01_PROCEDURE> GetAllPROCEDURERecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<BAR_P01_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Get GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetGT1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<GT1> GetAllGT1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetNK1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get INSURANCE Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from BAR_P01_VISIT
        /// </summary>
        public static List<BAR_P01_INSURANCE> GetAllINSURANCERecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<BAR_P01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get DB1 Records from BAR_P02_PATIENT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P02_PATIENT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P02_PATIENT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P02_PATIENT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get IN3 Records from BAR_P05_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this BAR_P05_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from BAR_P05_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this BAR_P05_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from BAR_P05_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from BAR_P05_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get ROL Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05_VISIT
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get DB1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Get OBX Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetOBXRecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from BAR_P05_VISIT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get AL1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get DG1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get PROCEDURE Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from BAR_P05_VISIT
        /// </summary>
        public static List<BAR_P05_PROCEDURE> GetAllPROCEDURERecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<BAR_P05_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Get GT1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetGT1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<GT1> GetAllGT1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get NK1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetNK1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get INSURANCE Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from BAR_P05_VISIT
        /// </summary>
        public static List<BAR_P05_INSURANCE> GetAllINSURANCERecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<BAR_P05_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get BLC Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetBLCRecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("BLCRepetitionsUsed", "GetBLC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all BLC Records from BAR_P05_VISIT
        /// </summary>
        public static List<BLC> GetAllBLCRecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<BLC>("BLCRepetitionsUsed", "GetBLC");
        }

        /// <summary>
        /// Get CSP Records from CRM_C01_PATIENT
        /// </summary>
        public static IEnumerable GetCSPRecords(this CRM_C01_PATIENT message)
        {
            object[] result = message.GetRecords("CSPRepetitionsUsed", "GetCSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CSP Records from CRM_C01_PATIENT
        /// </summary>
        public static List<CSP> GetAllCSPRecords(this CRM_C01_PATIENT message)
        {
            return message.GetAllRecords<CSP>("CSPRepetitionsUsed", "GetCSP");
        }

        /// <summary>
        /// Get NTE Records from CSU_C09_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this CSU_C09_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from CSU_C09_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this CSU_C09_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get STUDY_PHASE Records from CSU_C09_PATIENT
        /// </summary>
        public static IEnumerable GetSTUDY_PHASERecords(this CSU_C09_PATIENT message)
        {
            object[] result = message.GetRecords("STUDY_PHASERepetitionsUsed", "GetSTUDY_PHASE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_PHASE Records from CSU_C09_PATIENT
        /// </summary>
        public static List<CSU_C09_STUDY_PHASE> GetAllSTUDY_PHASERecords(this CSU_C09_PATIENT message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_PHASE>("STUDY_PHASERepetitionsUsed", "GetSTUDY_PHASE");
        }

        /// <summary>
        /// Get OBX Records from CSU_C09_STUDY_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBXRecords(this CSU_C09_STUDY_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from CSU_C09_STUDY_OBSERVATION
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this CSU_C09_STUDY_OBSERVATION message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get RX_ADMIN Records from CSU_C09_STUDY_PHARM
        /// </summary>
        public static IEnumerable GetRX_ADMINRecords(this CSU_C09_STUDY_PHARM message)
        {
            object[] result = message.GetRecords("RX_ADMINRepetitionsUsed", "GetRX_ADMIN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RX_ADMIN Records from CSU_C09_STUDY_PHARM
        /// </summary>
        public static List<CSU_C09_RX_ADMIN> GetAllRX_ADMINRecords(this CSU_C09_STUDY_PHARM message)
        {
            return message.GetAllRecords<CSU_C09_RX_ADMIN>("RX_ADMINRepetitionsUsed", "GetRX_ADMIN");
        }

        /// <summary>
        /// Get CSP Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static IEnumerable GetCSPRecords(this CSU_C09_STUDY_PHASE message)
        {
            object[] result = message.GetRecords("CSPRepetitionsUsed", "GetCSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CSP Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static List<CSP> GetAllCSPRecords(this CSU_C09_STUDY_PHASE message)
        {
            return message.GetAllRecords<CSP>("CSPRepetitionsUsed", "GetCSP");
        }

        /// <summary>
        /// Get STUDY_SCHEDULE Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static IEnumerable GetSTUDY_SCHEDULERecords(this CSU_C09_STUDY_PHASE message)
        {
            object[] result = message.GetRecords("STUDY_SCHEDULERepetitionsUsed", "GetSTUDY_SCHEDULE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_SCHEDULE Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static List<CSU_C09_STUDY_SCHEDULE> GetAllSTUDY_SCHEDULERecords(this CSU_C09_STUDY_PHASE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_SCHEDULE>("STUDY_SCHEDULERepetitionsUsed", "GetSTUDY_SCHEDULE");
        }

        /// <summary>
        /// Get STUDY_OBSERVATION Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static IEnumerable GetSTUDY_OBSERVATIONRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            object[] result = message.GetRecords("STUDY_OBSERVATIONRepetitionsUsed", "GetSTUDY_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_OBSERVATION Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static List<CSU_C09_STUDY_OBSERVATION> GetAllSTUDY_OBSERVATIONRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_OBSERVATION>("STUDY_OBSERVATIONRepetitionsUsed", "GetSTUDY_OBSERVATION");
        }

        /// <summary>
        /// Get STUDY_PHARM Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static IEnumerable GetSTUDY_PHARMRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            object[] result = message.GetRecords("STUDY_PHARMRepetitionsUsed", "GetSTUDY_PHARM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_PHARM Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static List<CSU_C09_STUDY_PHARM> GetAllSTUDY_PHARMRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_PHARM>("STUDY_PHARMRepetitionsUsed", "GetSTUDY_PHARM");
        }

        /// <summary>
        /// Get OBSERVATION Records from DFT_P03_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this DFT_P03_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from DFT_P03_COMMON_ORDER
        /// </summary>
        public static List<DFT_P03_OBSERVATION> GetAllOBSERVATIONRecords(this DFT_P03_COMMON_ORDER message)
        {
            return message.GetAllRecords<DFT_P03_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get FINANCIAL_PROCEDURE Records from DFT_P03_FINANCIAL
        /// </summary>
        public static IEnumerable GetFINANCIAL_PROCEDURERecords(this DFT_P03_FINANCIAL message)
        {
            object[] result = message.GetRecords("FINANCIAL_PROCEDURERepetitionsUsed", "GetFINANCIAL_PROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_PROCEDURE Records from DFT_P03_FINANCIAL
        /// </summary>
        public static List<DFT_P03_FINANCIAL_PROCEDURE> GetAllFINANCIAL_PROCEDURERecords(this DFT_P03_FINANCIAL message)
        {
            return message.GetAllRecords<DFT_P03_FINANCIAL_PROCEDURE>("FINANCIAL_PROCEDURERepetitionsUsed", "GetFINANCIAL_PROCEDURE");
        }

        /// <summary>
        /// Get FINANCIAL_COMMON_ORDER Records from DFT_P03_FINANCIAL
        /// </summary>
        public static IEnumerable GetFINANCIAL_COMMON_ORDERRecords(this DFT_P03_FINANCIAL message)
        {
            object[] result = message.GetRecords("FINANCIAL_COMMON_ORDERRepetitionsUsed", "GetFINANCIAL_COMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_COMMON_ORDER Records from DFT_P03_FINANCIAL
        /// </summary>
        public static List<DFT_P03_FINANCIAL_COMMON_ORDER> GetAllFINANCIAL_COMMON_ORDERRecords(this DFT_P03_FINANCIAL message)
        {
            return message.GetAllRecords<DFT_P03_FINANCIAL_COMMON_ORDER>("FINANCIAL_COMMON_ORDERRepetitionsUsed", "GetFINANCIAL_COMMON_ORDER");
        }

        /// <summary>
        /// Get FINANCIAL_OBSERVATION Records from DFT_P03_FINANCIAL_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetFINANCIAL_OBSERVATIONRecords(this DFT_P03_FINANCIAL_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("FINANCIAL_OBSERVATIONRepetitionsUsed", "GetFINANCIAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_OBSERVATION Records from DFT_P03_FINANCIAL_COMMON_ORDER
        /// </summary>
        public static List<DFT_P03_FINANCIAL_OBSERVATION> GetAllFINANCIAL_OBSERVATIONRecords(this DFT_P03_FINANCIAL_COMMON_ORDER message)
        {
            return message.GetAllRecords<DFT_P03_FINANCIAL_OBSERVATION>("FINANCIAL_OBSERVATIONRepetitionsUsed", "GetFINANCIAL_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_FINANCIAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_FINANCIAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_FINANCIAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_FINANCIAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_FINANCIAL_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_FINANCIAL_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_FINANCIAL_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_FINANCIAL_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ROL Records from DFT_P03_FINANCIAL_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P03_FINANCIAL_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get IN3 Records from DFT_P03_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this DFT_P03_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from DFT_P03_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this DFT_P03_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from DFT_P03_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P03_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P03_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P03_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from DFT_P03_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P03_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P03_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P03_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from DFT_P11_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this DFT_P11_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from DFT_P11_COMMON_ORDER
        /// </summary>
        public static List<DFT_P11_OBSERVATION> GetAllOBSERVATIONRecords(this DFT_P11_COMMON_ORDER message)
        {
            return message.GetAllRecords<DFT_P11_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get FINANCIAL_PROCEDURE Records from DFT_P11_FINANCIAL
        /// </summary>
        public static IEnumerable GetFINANCIAL_PROCEDURERecords(this DFT_P11_FINANCIAL message)
        {
            object[] result = message.GetRecords("FINANCIAL_PROCEDURERepetitionsUsed", "GetFINANCIAL_PROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_PROCEDURE Records from DFT_P11_FINANCIAL
        /// </summary>
        public static List<DFT_P11_FINANCIAL_PROCEDURE> GetAllFINANCIAL_PROCEDURERecords(this DFT_P11_FINANCIAL message)
        {
            return message.GetAllRecords<DFT_P11_FINANCIAL_PROCEDURE>("FINANCIAL_PROCEDURERepetitionsUsed", "GetFINANCIAL_PROCEDURE");
        }

        /// <summary>
        /// Get FINANCIAL_COMMON_ORDER Records from DFT_P11_FINANCIAL
        /// </summary>
        public static IEnumerable GetFINANCIAL_COMMON_ORDERRecords(this DFT_P11_FINANCIAL message)
        {
            object[] result = message.GetRecords("FINANCIAL_COMMON_ORDERRepetitionsUsed", "GetFINANCIAL_COMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_COMMON_ORDER Records from DFT_P11_FINANCIAL
        /// </summary>
        public static List<DFT_P11_FINANCIAL_COMMON_ORDER> GetAllFINANCIAL_COMMON_ORDERRecords(this DFT_P11_FINANCIAL message)
        {
            return message.GetAllRecords<DFT_P11_FINANCIAL_COMMON_ORDER>("FINANCIAL_COMMON_ORDERRepetitionsUsed", "GetFINANCIAL_COMMON_ORDER");
        }

        /// <summary>
        /// Get DG1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static IEnumerable GetDG1Records(this DFT_P11_FINANCIAL message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static List<DG1> GetAllDG1Records(this DFT_P11_FINANCIAL message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get GT1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static IEnumerable GetGT1Records(this DFT_P11_FINANCIAL message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from DFT_P11_FINANCIAL
        /// </summary>
        public static List<GT1> GetAllGT1Records(this DFT_P11_FINANCIAL message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get FINANCIAL_INSURANCE Records from DFT_P11_FINANCIAL
        /// </summary>
        public static IEnumerable GetFINANCIAL_INSURANCERecords(this DFT_P11_FINANCIAL message)
        {
            object[] result = message.GetRecords("FINANCIAL_INSURANCERepetitionsUsed", "GetFINANCIAL_INSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_INSURANCE Records from DFT_P11_FINANCIAL
        /// </summary>
        public static List<DFT_P11_FINANCIAL_INSURANCE> GetAllFINANCIAL_INSURANCERecords(this DFT_P11_FINANCIAL message)
        {
            return message.GetAllRecords<DFT_P11_FINANCIAL_INSURANCE>("FINANCIAL_INSURANCERepetitionsUsed", "GetFINANCIAL_INSURANCE");
        }

        /// <summary>
        /// Get FINANCIAL_OBSERVATION Records from DFT_P11_FINANCIAL_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetFINANCIAL_OBSERVATIONRecords(this DFT_P11_FINANCIAL_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("FINANCIAL_OBSERVATIONRepetitionsUsed", "GetFINANCIAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_OBSERVATION Records from DFT_P11_FINANCIAL_COMMON_ORDER
        /// </summary>
        public static List<DFT_P11_FINANCIAL_OBSERVATION> GetAllFINANCIAL_OBSERVATIONRecords(this DFT_P11_FINANCIAL_COMMON_ORDER message)
        {
            return message.GetAllRecords<DFT_P11_FINANCIAL_OBSERVATION>("FINANCIAL_OBSERVATIONRepetitionsUsed", "GetFINANCIAL_OBSERVATION");
        }

        /// <summary>
        /// Get IN3 Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P11_FINANCIAL_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P11_FINANCIAL_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_FINANCIAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_FINANCIAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_FINANCIAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_FINANCIAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_FINANCIAL_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_FINANCIAL_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_FINANCIAL_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_FINANCIAL_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ROL Records from DFT_P11_FINANCIAL_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P11_FINANCIAL_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P11_FINANCIAL_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P11_FINANCIAL_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get IN3 Records from DFT_P11_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this DFT_P11_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from DFT_P11_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this DFT_P11_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Get ROL Records from DFT_P11_INSURANCE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P11_INSURANCE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P11_INSURANCE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P11_INSURANCE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from DFT_P11_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this DFT_P11_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from DFT_P11_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this DFT_P11_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBX Records from DOC_T12_RESULT
        /// </summary>
        public static IEnumerable GetOBXRecords(this DOC_T12_RESULT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from DOC_T12_RESULT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this DOC_T12_RESULT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get PRC Records from MFN_M04_MF_CDM
        /// </summary>
        public static IEnumerable GetPRCRecords(this MFN_M04_MF_CDM message)
        {
            object[] result = message.GetRecords("PRCRepetitionsUsed", "GetPRC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRC Records from MFN_M04_MF_CDM
        /// </summary>
        public static List<PRC> GetAllPRCRecords(this MFN_M04_MF_CDM message)
        {
            return message.GetAllRecords<PRC>("PRCRepetitionsUsed", "GetPRC");
        }

        /// <summary>
        /// Get LCH Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetLCHRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Get LRL Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetLRLRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("LRLRepetitionsUsed", "GetLRL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LRL Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<LRL> GetAllLRLRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<LRL>("LRLRepetitionsUsed", "GetLRL");
        }

        /// <summary>
        /// Get MF_LOC_DEPT Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetMF_LOC_DEPTRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_LOC_DEPT Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<MFN_M05_MF_LOC_DEPT> GetAllMF_LOC_DEPTRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<MFN_M05_MF_LOC_DEPT>("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");
        }

        /// <summary>
        /// Get LCH Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCHRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Get LCC Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCCRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCCRepetitionsUsed", "GetLCC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCC Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static List<LCC> GetAllLCCRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCC>("LCCRepetitionsUsed", "GetLCC");
        }

        /// <summary>
        /// Get MF_PHASE_SCHED_DETAIL Records from MFN_M06_MF_CLIN_STUDY
        /// </summary>
        public static IEnumerable GetMF_PHASE_SCHED_DETAILRecords(this MFN_M06_MF_CLIN_STUDY message)
        {
            object[] result = message.GetRecords("MF_PHASE_SCHED_DETAILRepetitionsUsed", "GetMF_PHASE_SCHED_DETAIL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_PHASE_SCHED_DETAIL Records from MFN_M06_MF_CLIN_STUDY
        /// </summary>
        public static List<MFN_M06_MF_PHASE_SCHED_DETAIL> GetAllMF_PHASE_SCHED_DETAILRecords(this MFN_M06_MF_CLIN_STUDY message)
        {
            return message.GetAllRecords<MFN_M06_MF_PHASE_SCHED_DETAIL>("MF_PHASE_SCHED_DETAILRepetitionsUsed", "GetMF_PHASE_SCHED_DETAIL");
        }

        /// <summary>
        /// Get CM2 Records from MFN_M06_MF_PHASE_SCHED_DETAIL
        /// </summary>
        public static IEnumerable GetCM2Records(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            object[] result = message.GetRecords("CM2RepetitionsUsed", "GetCM2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM2 Records from MFN_M06_MF_PHASE_SCHED_DETAIL
        /// </summary>
        public static List<CM2> GetAllCM2Records(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            return message.GetAllRecords<CM2>("CM2RepetitionsUsed", "GetCM2");
        }

        /// <summary>
        /// Get CM2 Records from MFN_M07_MF_CLIN_STUDY_SCHED
        /// </summary>
        public static IEnumerable GetCM2Records(this MFN_M07_MF_CLIN_STUDY_SCHED message)
        {
            object[] result = message.GetRecords("CM2RepetitionsUsed", "GetCM2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM2 Records from MFN_M07_MF_CLIN_STUDY_SCHED
        /// </summary>
        public static List<CM2> GetAllCM2Records(this MFN_M07_MF_CLIN_STUDY_SCHED message)
        {
            return message.GetAllRecords<CM2>("CM2RepetitionsUsed", "GetCM2");
        }

        /// <summary>
        /// Get OM4 Records from MFN_M09_MF_TEST_CAT_DETAIL
        /// </summary>
        public static IEnumerable GetOM4Records(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            object[] result = message.GetRecords("OM4RepetitionsUsed", "GetOM4");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OM4 Records from MFN_M09_MF_TEST_CAT_DETAIL
        /// </summary>
        public static List<OM4> GetAllOM4Records(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            return message.GetAllRecords<OM4>("OM4RepetitionsUsed", "GetOM4");
        }

        /// <summary>
        /// Get OM4 Records from MFN_M10_MF_TEST_BATT_DETAIL
        /// </summary>
        public static IEnumerable GetOM4Records(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            object[] result = message.GetRecords("OM4RepetitionsUsed", "GetOM4");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OM4 Records from MFN_M10_MF_TEST_BATT_DETAIL
        /// </summary>
        public static List<OM4> GetAllOM4Records(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            return message.GetAllRecords<OM4>("OM4RepetitionsUsed", "GetOM4");
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_APP_STATS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_APP_STATS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_APP_STATS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_APP_STATS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_APP_STATUS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_APP_STATUS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_APP_STATUS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_APP_STATUS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_CLOCK
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_CLOCK message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_CLOCK
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_CLOCK message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTERecords(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE2 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE2Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE2RepetitionsUsed", "GetNTE2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE2 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE2Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE2RepetitionsUsed", "GetNTE2");
        }

        /// <summary>
        /// Get NTE3 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE3Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE3RepetitionsUsed", "GetNTE3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE3 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE3Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE3RepetitionsUsed", "GetNTE3");
        }

        /// <summary>
        /// Get ODS Records from OMD_O03_DIET
        /// </summary>
        public static IEnumerable GetODSRecords(this OMD_O03_DIET message)
        {
            object[] result = message.GetRecords("ODSRepetitionsUsed", "GetODS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODS Records from OMD_O03_DIET
        /// </summary>
        public static List<ODS> GetAllODSRecords(this OMD_O03_DIET message)
        {
            return message.GetAllRecords<ODS>("ODSRepetitionsUsed", "GetODS");
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_DIET
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_DIET message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_DIET
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_DIET message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from OMD_O03_DIET
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMD_O03_DIET message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMD_O03_DIET
        /// </summary>
        public static List<OMD_O03_OBSERVATION> GetAllOBSERVATIONRecords(this OMD_O03_DIET message)
        {
            return message.GetAllRecords<OMD_O03_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ODT Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetODTRecords(this OMD_O03_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("ODTRepetitionsUsed", "GetODT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODT Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static List<ODT> GetAllODTRecords(this OMD_O03_ORDER_TRAY message)
        {
            return message.GetAllRecords<ODT>("ODTRepetitionsUsed", "GetODT");
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_ORDER_TRAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_ORDER_TRAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OMD_O03_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O03_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O03_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O03_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from OMD_O03_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMD_O03_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMD_O03_PATIENT
        /// </summary>
        public static List<OMD_O03_INSURANCE> GetAllINSURANCERecords(this OMD_O03_PATIENT message)
        {
            return message.GetAllRecords<OMD_O03_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from OMD_O03_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMD_O03_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMD_O03_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMD_O03_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_OBSERVATION_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_OBSERVATION_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_OBSERVATION_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_OBSERVATION_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get DG1 Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetDG1Records(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OMG_O19_ORDER
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get OBSERVATION Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMG_O19_ORDER
        /// </summary>
        public static List<OMG_O19_OBSERVATION> GetAllOBSERVATIONRecords(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<OMG_O19_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get PRIOR_RESULT Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetPRIOR_RESULTRecords(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("PRIOR_RESULTRepetitionsUsed", "GetPRIOR_RESULT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRIOR_RESULT Records from OMG_O19_ORDER
        /// </summary>
        public static List<OMG_O19_PRIOR_RESULT> GetAllPRIOR_RESULTRecords(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<OMG_O19_PRIOR_RESULT>("PRIOR_RESULTRepetitionsUsed", "GetPRIOR_RESULT");
        }

        /// <summary>
        /// Get FT1 Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OMG_O19_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Get CTI Records from OMG_O19_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OMG_O19_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OMG_O19_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OMG_O19_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_ORDER_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION_PRIOR Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetOBSERVATION_PRIORRecords(this OMG_O19_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION_PRIOR Records from OMG_O19_ORDER_PRIOR
        /// </summary>
        public static List<OMG_O19_OBSERVATION_PRIOR> GetAllOBSERVATION_PRIORRecords(this OMG_O19_ORDER_PRIOR message)
        {
            return message.GetAllRecords<OMG_O19_OBSERVATION_PRIOR>("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");
        }

        /// <summary>
        /// Get NTE Records from OMG_O19_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMG_O19_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMG_O19_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMG_O19_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from OMG_O19_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMG_O19_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMG_O19_PATIENT
        /// </summary>
        public static List<OMG_O19_INSURANCE> GetAllINSURANCERecords(this OMG_O19_PATIENT message)
        {
            return message.GetAllRecords<OMG_O19_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from OMG_O19_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMG_O19_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMG_O19_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMG_O19_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get AL1 Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMG_O19_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMG_O19_PRIOR_RESULT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get ORDER_PRIOR Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetORDER_PRIORRecords(this OMG_O19_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_PRIOR Records from OMG_O19_PRIOR_RESULT
        /// </summary>
        public static List<OMG_O19_ORDER_PRIOR> GetAllORDER_PRIORRecords(this OMG_O19_PRIOR_RESULT message)
        {
            return message.GetAllRecords<OMG_O19_ORDER_PRIOR>("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");
        }

        /// <summary>
        /// Get OBX Records from OML_O21_CONTAINER_1
        /// </summary>
        public static IEnumerable GetOBXRecords(this OML_O21_CONTAINER_1 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OML_O21_CONTAINER_1
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OML_O21_CONTAINER_1 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get OBX Records from OML_O21_CONTAINER_2
        /// </summary>
        public static IEnumerable GetOBXRecords(this OML_O21_CONTAINER_2 message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OML_O21_CONTAINER_2
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OML_O21_CONTAINER_2 message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get NTE Records from OML_O21_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OML_O21_OBSERVATION_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_OBSERVATION_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_OBSERVATION_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_OBSERVATION_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get CONTAINER_2 Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetCONTAINER_2Records(this OML_O21_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("CONTAINER_2RepetitionsUsed", "GetCONTAINER_2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CONTAINER_2 Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static List<OML_O21_CONTAINER_2> GetAllCONTAINER_2Records(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<OML_O21_CONTAINER_2>("CONTAINER_2RepetitionsUsed", "GetCONTAINER_2");
        }

        /// <summary>
        /// Get NTE Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get DG1 Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetDG1Records(this OML_O21_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static List<DG1> GetAllDG1Records(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get OBSERVATION Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static List<OML_O21_OBSERVATION> GetAllOBSERVATIONRecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<OML_O21_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get PRIOR_RESULT Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetPRIOR_RESULTRecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("PRIOR_RESULTRepetitionsUsed", "GetPRIOR_RESULT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRIOR_RESULT Records from OML_O21_OBSERVATION_REQUEST
        /// </summary>
        public static List<OML_O21_PRIOR_RESULT> GetAllPRIOR_RESULTRecords(this OML_O21_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<OML_O21_PRIOR_RESULT>("PRIOR_RESULTRepetitionsUsed", "GetPRIOR_RESULT");
        }

        /// <summary>
        /// Get FT1 Records from OML_O21_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OML_O21_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OML_O21_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OML_O21_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Get CTI Records from OML_O21_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OML_O21_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OML_O21_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OML_O21_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get ORDER Records from OML_O21_ORDER_GENERAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this OML_O21_ORDER_GENERAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OML_O21_ORDER_GENERAL
        /// </summary>
        public static List<OML_O21_ORDER> GetAllORDERRecords(this OML_O21_ORDER_GENERAL message)
        {
            return message.GetAllRecords<OML_O21_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_ORDER_PRIOR message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION_PRIOR Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static IEnumerable GetOBSERVATION_PRIORRecords(this OML_O21_ORDER_PRIOR message)
        {
            object[] result = message.GetRecords("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION_PRIOR Records from OML_O21_ORDER_PRIOR
        /// </summary>
        public static List<OML_O21_OBSERVATION_PRIOR> GetAllOBSERVATION_PRIORRecords(this OML_O21_ORDER_PRIOR message)
        {
            return message.GetAllRecords<OML_O21_OBSERVATION_PRIOR>("OBSERVATION_PRIORRepetitionsUsed", "GetOBSERVATION_PRIOR");
        }

        /// <summary>
        /// Get NTE Records from OML_O21_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OML_O21_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OML_O21_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OML_O21_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from OML_O21_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OML_O21_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OML_O21_PATIENT
        /// </summary>
        public static List<OML_O21_INSURANCE> GetAllINSURANCERecords(this OML_O21_PATIENT message)
        {
            return message.GetAllRecords<OML_O21_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from OML_O21_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O21_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O21_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O21_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get AL1 Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetAL1Records(this OML_O21_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OML_O21_PRIOR_RESULT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get ORDER_PRIOR Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static IEnumerable GetORDER_PRIORRecords(this OML_O21_PRIOR_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_PRIOR Records from OML_O21_PRIOR_RESULT
        /// </summary>
        public static List<OML_O21_ORDER_PRIOR> GetAllORDER_PRIORRecords(this OML_O21_PRIOR_RESULT message)
        {
            return message.GetAllRecords<OML_O21_ORDER_PRIOR>("ORDER_PRIORRepetitionsUsed", "GetORDER_PRIOR");
        }

        /// <summary>
        /// Get NTE Records from OMN_O07_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O07_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O07_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O07_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OMN_O07_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O07_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O07_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O07_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from OMN_O07_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMN_O07_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMN_O07_ORDER
        /// </summary>
        public static List<OMN_O07_OBSERVATION> GetAllOBSERVATIONRecords(this OMN_O07_ORDER message)
        {
            return message.GetAllRecords<OMN_O07_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from OMN_O07_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O07_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O07_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O07_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from OMN_O07_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMN_O07_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMN_O07_PATIENT
        /// </summary>
        public static List<OMN_O07_INSURANCE> GetAllINSURANCERecords(this OMN_O07_PATIENT message)
        {
            return message.GetAllRecords<OMN_O07_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from OMN_O07_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMN_O07_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMN_O07_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMN_O07_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get RXC Records from OMP_O09_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this OMP_O09_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from OMP_O09_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this OMP_O09_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from OMP_O09_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this OMP_O09_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from OMP_O09_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this OMP_O09_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get OBSERVATION Records from OMP_O09_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMP_O09_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMP_O09_ORDER
        /// </summary>
        public static List<OMP_O09_OBSERVATION> GetAllOBSERVATIONRecords(this OMP_O09_ORDER message)
        {
            return message.GetAllRecords<OMP_O09_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get FT1 Records from OMP_O09_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this OMP_O09_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from OMP_O09_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this OMP_O09_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Get NTE Records from OMP_O09_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMP_O09_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMP_O09_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMP_O09_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from OMP_O09_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMP_O09_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMP_O09_PATIENT
        /// </summary>
        public static List<OMP_O09_INSURANCE> GetAllINSURANCERecords(this OMP_O09_PATIENT message)
        {
            return message.GetAllRecords<OMP_O09_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from OMP_O09_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMP_O09_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMP_O09_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMP_O09_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get NTE Records from OMS_O05_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O05_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O05_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O05_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OMS_O05_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O05_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O05_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O05_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from OMS_O05_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMS_O05_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMS_O05_ORDER
        /// </summary>
        public static List<OMS_O05_OBSERVATION> GetAllOBSERVATIONRecords(this OMS_O05_ORDER message)
        {
            return message.GetAllRecords<OMS_O05_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from OMS_O05_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O05_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O05_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O05_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from OMS_O05_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMS_O05_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMS_O05_PATIENT
        /// </summary>
        public static List<OMS_O05_INSURANCE> GetAllINSURANCERecords(this OMS_O05_PATIENT message)
        {
            return message.GetAllRecords<OMS_O05_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from OMS_O05_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMS_O05_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMS_O05_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMS_O05_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get ODS Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static IEnumerable GetODSRecords(this ORD_O04_ORDER_DIET message)
        {
            object[] result = message.GetRecords("ODSRepetitionsUsed", "GetODS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODS Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static List<ODS> GetAllODSRecords(this ORD_O04_ORDER_DIET message)
        {
            return message.GetAllRecords<ODS>("ODSRepetitionsUsed", "GetODS");
        }

        /// <summary>
        /// Get NTE Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O04_ORDER_DIET message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O04_ORDER_DIET
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O04_ORDER_DIET message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ODT Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetODTRecords(this ORD_O04_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("ODTRepetitionsUsed", "GetODT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODT Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static List<ODT> GetAllODTRecords(this ORD_O04_ORDER_TRAY message)
        {
            return message.GetAllRecords<ODT>("ODTRepetitionsUsed", "GetODT");
        }

        /// <summary>
        /// Get NTE Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O04_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O04_ORDER_TRAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O04_ORDER_TRAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORD_O04_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O04_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O04_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O04_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER_DIET Records from ORD_O04_RESPONSE
        /// </summary>
        public static IEnumerable GetORDER_DIETRecords(this ORD_O04_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_DIET Records from ORD_O04_RESPONSE
        /// </summary>
        public static List<ORD_O04_ORDER_DIET> GetAllORDER_DIETRecords(this ORD_O04_RESPONSE message)
        {
            return message.GetAllRecords<ORD_O04_ORDER_DIET>("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");
        }

        /// <summary>
        /// Get ORDER_TRAY Records from ORD_O04_RESPONSE
        /// </summary>
        public static IEnumerable GetORDER_TRAYRecords(this ORD_O04_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_TRAY Records from ORD_O04_RESPONSE
        /// </summary>
        public static List<ORD_O04_ORDER_TRAY> GetAllORDER_TRAYRecords(this ORD_O04_RESPONSE message)
        {
            return message.GetAllRecords<ORD_O04_ORDER_TRAY>("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORF_R04_ORDER
        /// </summary>
        public static List<ORF_R04_OBSERVATION> GetAllOBSERVATIONRecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<ORF_R04_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get CTI Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORF_R04_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORF_R04_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORF_R04_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORF_R04_RESPONSE
        /// </summary>
        public static List<ORF_R04_ORDER> GetAllORDERRecords(this ORF_R04_RESPONSE message)
        {
            return message.GetAllRecords<ORF_R04_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from ORG_O20_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORG_O20_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORG_O20_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORG_O20_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get CTI Records from ORG_O20_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORG_O20_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORG_O20_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORG_O20_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from ORG_O20_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORG_O20_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORG_O20_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORG_O20_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORG_O20_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORG_O20_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORG_O20_RESPONSE
        /// </summary>
        public static List<ORG_O20_ORDER> GetAllORDERRecords(this ORG_O20_RESPONSE message)
        {
            return message.GetAllRecords<ORG_O20_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get OBX Records from ORL_O22_CONTAINER
        /// </summary>
        public static IEnumerable GetOBXRecords(this ORL_O22_CONTAINER message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ORL_O22_CONTAINER
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ORL_O22_CONTAINER message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get ORDER Records from ORL_O22_GENERAL_ORDER
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORL_O22_GENERAL_ORDER message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORL_O22_GENERAL_ORDER
        /// </summary>
        public static List<ORL_O22_ORDER> GetAllORDERRecords(this ORL_O22_GENERAL_ORDER message)
        {
            return message.GetAllRecords<ORL_O22_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get SAC Records from ORL_O22_OBSERVATION_REQUEST
        /// </summary>
        public static IEnumerable GetSACRecords(this ORL_O22_OBSERVATION_REQUEST message)
        {
            object[] result = message.GetRecords("SACRepetitionsUsed", "GetSAC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SAC Records from ORL_O22_OBSERVATION_REQUEST
        /// </summary>
        public static List<SAC> GetAllSACRecords(this ORL_O22_OBSERVATION_REQUEST message)
        {
            return message.GetAllRecords<SAC>("SACRepetitionsUsed", "GetSAC");
        }

        /// <summary>
        /// Get GENERAL_ORDER Records from ORL_O22_PATIENT
        /// </summary>
        public static IEnumerable GetGENERAL_ORDERRecords(this ORL_O22_PATIENT message)
        {
            object[] result = message.GetRecords("GENERAL_ORDERRepetitionsUsed", "GetGENERAL_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_ORDER Records from ORL_O22_PATIENT
        /// </summary>
        public static List<ORL_O22_GENERAL_ORDER> GetAllGENERAL_ORDERRecords(this ORL_O22_PATIENT message)
        {
            return message.GetAllRecords<ORL_O22_GENERAL_ORDER>("GENERAL_ORDERRepetitionsUsed", "GetGENERAL_ORDER");
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get FT1 Records from ORM_O01_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this ORM_O01_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from ORM_O01_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this ORM_O01_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Get CTI Records from ORM_O01_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORM_O01_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORM_O01_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORM_O01_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get DG1 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetDG1Records(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get OBSERVATION Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<ORM_O01_OBSERVATION> GetAllOBSERVATIONRecords(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<ORM_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ORM_O01_PATIENT
        /// </summary>
        public static List<ORM_O01_INSURANCE> GetAllINSURANCERecords(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<ORM_O01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ORM_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get NTE Records from ORN_O08_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O08_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O08_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O08_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORN_O08_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O08_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O08_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O08_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORN_O08_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORN_O08_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORN_O08_RESPONSE
        /// </summary>
        public static List<ORN_O08_ORDER> GetAllORDERRecords(this ORN_O08_RESPONSE message)
        {
            return message.GetAllRecords<ORN_O08_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this ORP_O10_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this ORP_O10_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXCRecords(this ORP_O10_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE2 Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTE2Records(this ORP_O10_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTE2RepetitionsUsed", "GetNTE2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE2 Records from ORP_O10_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTE2Records(this ORP_O10_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTE2RepetitionsUsed", "GetNTE2");
        }

        /// <summary>
        /// Get NTE Records from ORP_O10_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORP_O10_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORP_O10_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORP_O10_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORP_O10_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORP_O10_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORP_O10_RESPONSE
        /// </summary>
        public static List<ORP_O10_ORDER> GetAllORDERRecords(this ORP_O10_RESPONSE message)
        {
            return message.GetAllRecords<ORP_O10_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get CTI Records from ORR_O02_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORR_O02_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORR_O02_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORR_O02_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORR_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORR_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORR_O02_RESPONSE
        /// </summary>
        public static List<ORR_O02_ORDER> GetAllORDERRecords(this ORR_O02_RESPONSE message)
        {
            return message.GetAllRecords<ORR_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from ORS_O06_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORS_O06_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORS_O06_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORS_O06_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORS_O06_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORS_O06_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORS_O06_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORS_O06_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from ORS_O06_RSPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORS_O06_RSPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORS_O06_RSPONSE
        /// </summary>
        public static List<ORS_O06_ORDER> GetAllORDERRecords(this ORS_O06_RSPONSE message)
        {
            return message.GetAllRecords<ORS_O06_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<ORU_R01_OBSERVATION> GetAllOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<ORU_R01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get FT1 Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetFT1Records(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<FT1> GetAllFT1Records(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Get CTI Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NK1 Records from ORU_R01_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this ORU_R01_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ORU_R01_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ORU_R01_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static List<ORU_R01_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            return message.GetAllRecords<ORU_R01_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from OSR_Q06_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this OSR_Q06_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OSR_Q06_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OSR_Q06_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get CTI Records from OSR_Q06_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this OSR_Q06_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OSR_Q06_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OSR_Q06_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from OSR_Q06_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OSR_Q06_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OSR_Q06_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OSR_Q06_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from OSR_Q06_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this OSR_Q06_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from OSR_Q06_RESPONSE
        /// </summary>
        public static List<OSR_Q06_ORDER> GetAllORDERRecords(this OSR_Q06_RESPONSE message)
        {
            return message.GetAllRecords<OSR_Q06_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get OBX Records from OUL_R21_CONTAINER
        /// </summary>
        public static IEnumerable GetOBXRecords(this OUL_R21_CONTAINER message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from OUL_R21_CONTAINER
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this OUL_R21_CONTAINER message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get SID Records from OUL_R21_OBSERVATION
        /// </summary>
        public static IEnumerable GetSIDRecords(this OUL_R21_OBSERVATION message)
        {
            object[] result = message.GetRecords("SIDRepetitionsUsed", "GetSID");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SID Records from OUL_R21_OBSERVATION
        /// </summary>
        public static List<SID> GetAllSIDRecords(this OUL_R21_OBSERVATION message)
        {
            return message.GetAllRecords<SID>("SIDRepetitionsUsed", "GetSID");
        }

        /// <summary>
        /// Get NTE Records from OUL_R21_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R21_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R21_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R21_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static List<OUL_R21_OBSERVATION> GetAllOBSERVATIONRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<OUL_R21_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get CTI Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetCTIRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OUL_R21_ORDER_OBSERVATION
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OUL_R21_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from OUL_R21_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OUL_R21_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OUL_R21_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OUL_R21_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ASSOCIATED_RX_ADMIN Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetASSOCIATED_RX_ADMINRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("ASSOCIATED_RX_ADMINRepetitionsUsed", "GetASSOCIATED_RX_ADMIN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ASSOCIATED_RX_ADMIN Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<PEX_P07_ASSOCIATED_RX_ADMIN> GetAllASSOCIATED_RX_ADMINRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<PEX_P07_ASSOCIATED_RX_ADMIN>("ASSOCIATED_RX_ADMINRepetitionsUsed", "GetASSOCIATED_RX_ADMIN");
        }

        /// <summary>
        /// Get PRB Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetPRBRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("PRBRepetitionsUsed", "GetPRB");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRB Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<PRB> GetAllPRBRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<PRB>("PRBRepetitionsUsed", "GetPRB");
        }

        /// <summary>
        /// Get OBX Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetOBXRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get RXR Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get PEX_OBSERVATION Records from PEX_P07_EXPERIENCE
        /// </summary>
        public static IEnumerable GetPEX_OBSERVATIONRecords(this PEX_P07_EXPERIENCE message)
        {
            object[] result = message.GetRecords("PEX_OBSERVATIONRepetitionsUsed", "GetPEX_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PEX_OBSERVATION Records from PEX_P07_EXPERIENCE
        /// </summary>
        public static List<PEX_P07_PEX_OBSERVATION> GetAllPEX_OBSERVATIONRecords(this PEX_P07_EXPERIENCE message)
        {
            return message.GetAllRecords<PEX_P07_PEX_OBSERVATION>("PEX_OBSERVATIONRepetitionsUsed", "GetPEX_OBSERVATION");
        }

        /// <summary>
        /// Get RX_ADMINISTRATION Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetRX_ADMINISTRATIONRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("RX_ADMINISTRATIONRepetitionsUsed", "GetRX_ADMINISTRATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RX_ADMINISTRATION Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<PEX_P07_RX_ADMINISTRATION> GetAllRX_ADMINISTRATIONRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<PEX_P07_RX_ADMINISTRATION>("RX_ADMINISTRATIONRepetitionsUsed", "GetRX_ADMINISTRATION");
        }

        /// <summary>
        /// Get PRB Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetPRBRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("PRBRepetitionsUsed", "GetPRB");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRB Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<PRB> GetAllPRBRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<PRB>("PRBRepetitionsUsed", "GetPRB");
        }

        /// <summary>
        /// Get OBX Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetOBXRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get NTE Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetNTERecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get STUDY Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetSTUDYRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("STUDYRepetitionsUsed", "GetSTUDY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<PEX_P07_STUDY> GetAllSTUDYRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<PEX_P07_STUDY>("STUDYRepetitionsUsed", "GetSTUDY");
        }

        /// <summary>
        /// Get PEX_CAUSE Records from PEX_P07_PEX_OBSERVATION
        /// </summary>
        public static IEnumerable GetPEX_CAUSERecords(this PEX_P07_PEX_OBSERVATION message)
        {
            object[] result = message.GetRecords("PEX_CAUSERepetitionsUsed", "GetPEX_CAUSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PEX_CAUSE Records from PEX_P07_PEX_OBSERVATION
        /// </summary>
        public static List<PEX_P07_PEX_CAUSE> GetAllPEX_CAUSERecords(this PEX_P07_PEX_OBSERVATION message)
        {
            return message.GetAllRecords<PEX_P07_PEX_CAUSE>("PEX_CAUSERepetitionsUsed", "GetPEX_CAUSE");
        }

        /// <summary>
        /// Get RXR Records from PEX_P07_RX_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this PEX_P07_RX_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from PEX_P07_RX_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this PEX_P07_RX_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get CSP Records from PEX_P07_STUDY
        /// </summary>
        public static IEnumerable GetCSPRecords(this PEX_P07_STUDY message)
        {
            object[] result = message.GetRecords("CSPRepetitionsUsed", "GetCSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CSP Records from PEX_P07_STUDY
        /// </summary>
        public static List<CSP> GetAllCSPRecords(this PEX_P07_STUDY message)
        {
            return message.GetAllRecords<CSP>("CSPRepetitionsUsed", "GetCSP");
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_GOAL_ROLE> GetAllGOAL_ROLERecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get PATHWAY Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_PATHWAY> GetAllPATHWAYRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Get OBSERVATION Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_OBSERVATION> GetAllOBSERVATIONRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get PROBLEM Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_PROBLEM> GetAllPROBLEMRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get ORDER Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_ORDER> GetAllORDERRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<PGL_PC6_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PGL_PC6_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<PGL_PC6_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<PGL_PC6_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<PGL_PC6_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<PGL_PC6_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Get PROBLEM Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_PROBLEM> GetAllPROBLEMRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get ORDER Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_ORDER> GetAllORDERRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<PPG_PCG_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPG_PCG_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<PPG_PCG_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<PPG_PCG_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Get GOAL Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<PPG_PCG_GOAL> GetAllGOALRecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<PPG_PCG_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<PPG_PCG_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<PPG_PCG_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<PPG_PCG_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<PPG_PCG_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPP_PCB_GOAL
        /// </summary>
        public static List<PPP_PCB_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<PPP_PCB_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPP_PCB_GOAL
        /// </summary>
        public static List<PPP_PCB_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<PPP_PCB_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<PPP_PCB_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPP_PCB_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<PPP_PCB_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<PPP_PCB_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Get PROBLEM Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<PPP_PCB_PROBLEM> GetAllPROBLEMRecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<PPP_PCB_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get GOAL Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_GOAL> GetAllGOALRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get ORDER Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_ORDER> GetAllORDERRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPR_PC1_GOAL
        /// </summary>
        public static List<PPR_PC1_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<PPR_PC1_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPR_PC1_GOAL
        /// </summary>
        public static List<PPR_PC1_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<PPR_PC1_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<PPR_PC1_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPR_PC1_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PATHWAY Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_PATHWAY> GetAllPATHWAYRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get GOAL Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_GOAL> GetAllGOALRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get ORDER Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_ORDER> GetAllORDERRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Get PROBLEM Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_PROBLEM> GetAllPROBLEMRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get ORDER Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_ORDER> GetAllORDERRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<PPT_PCL_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPT_PCL_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<PPT_PCL_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<PPT_PCL_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Get GOAL Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<PPT_PCL_GOAL> GetAllGOALRecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<PPT_PCL_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PATHWAY Records from PPT_PCL_PATIENT
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPT_PCL_PATIENT message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPT_PCL_PATIENT
        /// </summary>
        public static List<PPT_PCL_PATHWAY> GetAllPATHWAYRecords(this PPT_PCL_PATIENT message)
        {
            return message.GetAllRecords<PPT_PCL_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<PPT_PCL_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<PPT_PCL_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<PPT_PCL_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<PPT_PCL_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get GOAL_PATHWAY Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_PATHWAYRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_PATHWAYRepetitionsUsed", "GetGOAL_PATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_PATHWAY Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_GOAL_PATHWAY> GetAllGOAL_PATHWAYRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL_PATHWAY>("GOAL_PATHWAYRepetitionsUsed", "GetGOAL_PATHWAY");
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Get PROBLEM Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_PROBLEM> GetAllPROBLEMRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get ORDER Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_ORDER> GetAllORDERRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<PPV_PCA_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPV_PCA_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL Records from PPV_PCA_PATIENT
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPV_PCA_PATIENT message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPV_PCA_PATIENT
        /// </summary>
        public static List<PPV_PCA_GOAL> GetAllGOALRecords(this PPV_PCA_PATIENT message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<PPV_PCA_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<PPV_PCA_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<PPV_PCA_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<PPV_PCA_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PRR_PC5_GOAL
        /// </summary>
        public static List<PRR_PC5_GOAL_ROLE> GetAllGOAL_ROLERecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<PRR_PC5_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PRR_PC5_GOAL
        /// </summary>
        public static List<PRR_PC5_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<PRR_PC5_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<PRR_PC5_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PRR_PC5_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM Records from PRR_PC5_PATIENT
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PRR_PC5_PATIENT message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PRR_PC5_PATIENT
        /// </summary>
        public static List<PRR_PC5_PROBLEM> GetAllPROBLEMRecords(this PRR_PC5_PATIENT message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PROBLEM_PATHWAY Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_PATHWAYRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_PATHWAYRepetitionsUsed", "GetPROBLEM_PATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_PATHWAY Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_PROBLEM_PATHWAY> GetAllPROBLEM_PATHWAYRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM_PATHWAY>("PROBLEM_PATHWAYRepetitionsUsed", "GetPROBLEM_PATHWAY");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get GOAL Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_GOAL> GetAllGOALRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get ORDER Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_ORDER> GetAllORDERRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PTR_PCF_GOAL
        /// </summary>
        public static List<PTR_PCF_GOAL_ROLE> GetAllGOAL_ROLERecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<PTR_PCF_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PTR_PCF_GOAL
        /// </summary>
        public static List<PTR_PCF_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<PTR_PCF_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<PTR_PCF_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PTR_PCF_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<PTR_PCF_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<PTR_PCF_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Get PROBLEM Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<PTR_PCF_PROBLEM> GetAllPROBLEMRecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<PTR_PCF_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PATHWAY Records from PTR_PCF_PATIENT
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PTR_PCF_PATIENT message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PTR_PCF_PATIENT
        /// </summary>
        public static List<PTR_PCF_PATHWAY> GetAllPATHWAYRecords(this PTR_PCF_PATIENT message)
        {
            return message.GetAllRecords<PTR_PCF_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Get GOAL Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_GOAL> GetAllGOALRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Get ORDER Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_ORDER> GetAllORDERRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Get RDT Records from QBP_K13_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this QBP_K13_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from QBP_K13_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this QBP_K13_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Get ORDER Records from RAR_RAR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RAR_RAR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RAR_RAR_DEFINITION
        /// </summary>
        public static List<RAR_RAR_ORDER> GetAllORDERRecords(this RAR_RAR_DEFINITION message)
        {
            return message.GetAllRecords<RAR_RAR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from RAR_RAR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAR_RAR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAR_RAR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAR_RAR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RAR_RAR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAR_RAR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAR_RAR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAR_RAR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get RXA Records from RAR_RAR_ORDER
        /// </summary>
        public static IEnumerable GetRXARecords(this RAR_RAR_ORDER message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RAR_RAR_ORDER
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RAR_RAR_ORDER message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Get NTE Records from RAR_RAR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAR_RAR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAR_RAR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAR_RAR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXC Records from RAS_O17_COMPONENTS
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAS_O17_COMPONENTS message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAS_O17_COMPONENTS
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAS_O17_COMPONENTS message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_COMPONENTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_COMPONENTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_COMPONENTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_COMPONENTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RAS_O17_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAS_O17_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAS_O17_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAS_O17_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RAS_O17_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAS_O17_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAS_O17_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAS_O17_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXA Records from RAS_O17_ORDER
        /// </summary>
        public static IEnumerable GetRXARecords(this RAS_O17_ORDER message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RAS_O17_ORDER
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RAS_O17_ORDER message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Get OBSERVATION Records from RAS_O17_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RAS_O17_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RAS_O17_ORDER
        /// </summary>
        public static List<RAS_O17_OBSERVATION> GetAllOBSERVATIONRecords(this RAS_O17_ORDER message)
        {
            return message.GetAllRecords<RAS_O17_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get CTI Records from RAS_O17_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this RAS_O17_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from RAS_O17_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this RAS_O17_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAS_O17_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAS_O17_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get NTE Records from RAS_O17_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O17_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O17_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O17_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get AL1 Records from RAS_O17_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RAS_O17_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RAS_O17_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RAS_O17_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get NTE Records from RCI_I05_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RCI_I05_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCI_I05_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCI_I05_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESULTS Records from RCI_I05_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RCI_I05_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RCI_I05_OBSERVATION
        /// </summary>
        public static List<RCI_I05_RESULTS> GetAllRESULTSRecords(this RCI_I05_OBSERVATION message)
        {
            return message.GetAllRecords<RCI_I05_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Get CTD Records from RCI_I05_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RCI_I05_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RCI_I05_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RCI_I05_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get NTE Records from RCI_I05_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RCI_I05_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCI_I05_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCI_I05_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get CTD Records from RCL_I06_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RCL_I06_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RCL_I06_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RCL_I06_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get RXC Records from RDE_O11_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDE_O11_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDE_O11_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDE_O11_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDE_O11_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDE_O11_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get OBSERVATION Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RDE_O11_ORDER
        /// </summary>
        public static List<RDE_O11_OBSERVATION> GetAllOBSERVATIONRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<RDE_O11_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get CTI Records from RDE_O11_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this RDE_O11_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from RDE_O11_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this RDE_O11_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDE_O11_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDE_O11_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDE_O11_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get NTE Records from RDE_O11_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O11_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O11_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O11_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get INSURANCE Records from RDE_O11_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RDE_O11_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RDE_O11_PATIENT
        /// </summary>
        public static List<RDE_O11_INSURANCE> GetAllINSURANCERecords(this RDE_O11_PATIENT message)
        {
            return message.GetAllRecords<RDE_O11_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get AL1 Records from RDE_O11_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RDE_O11_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RDE_O11_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RDE_O11_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get ORDER Records from RDR_RDR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RDR_RDR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RDR_RDR_DEFINITION
        /// </summary>
        public static List<RDR_RDR_ORDER> GetAllORDERRecords(this RDR_RDR_DEFINITION message)
        {
            return message.GetAllRecords<RDR_RDR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from RDR_RDR_DISPENSE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDR_RDR_DISPENSE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDR_RDR_DISPENSE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDR_RDR_DISPENSE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RDR_RDR_DISPENSE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDR_RDR_DISPENSE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDR_RDR_DISPENSE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDR_RDR_DISPENSE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get RXR Records from RDR_RDR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDR_RDR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDR_RDR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDR_RDR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RDR_RDR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDR_RDR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDR_RDR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDR_RDR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get DISPENSE Records from RDR_RDR_ORDER
        /// </summary>
        public static IEnumerable GetDISPENSERecords(this RDR_RDR_ORDER message)
        {
            object[] result = message.GetRecords("DISPENSERepetitionsUsed", "GetDISPENSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DISPENSE Records from RDR_RDR_ORDER
        /// </summary>
        public static List<RDR_RDR_DISPENSE> GetAllDISPENSERecords(this RDR_RDR_ORDER message)
        {
            return message.GetAllRecords<RDR_RDR_DISPENSE>("DISPENSERepetitionsUsed", "GetDISPENSE");
        }

        /// <summary>
        /// Get NTE Records from RDR_RDR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDR_RDR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDR_RDR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDR_RDR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXC Records from RDS_O13_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O13_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O13_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O13_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RDS_O13_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O13_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O13_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O13_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RDS_O13_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O13_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O13_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O13_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O13_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O13_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get OBSERVATION Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RDS_O13_ORDER
        /// </summary>
        public static List<RDS_O13_OBSERVATION> GetAllOBSERVATIONRecords(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<RDS_O13_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get FT1 Records from RDS_O13_ORDER
        /// </summary>
        public static IEnumerable GetFT1Records(this RDS_O13_ORDER message)
        {
            object[] result = message.GetRecords("FT1RepetitionsUsed", "GetFT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FT1 Records from RDS_O13_ORDER
        /// </summary>
        public static List<FT1> GetAllFT1Records(this RDS_O13_ORDER message)
        {
            return message.GetAllRecords<FT1>("FT1RepetitionsUsed", "GetFT1");
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O13_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O13_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get NTE Records from RDS_O13_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O13_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O13_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O13_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get AL1 Records from RDS_O13_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RDS_O13_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RDS_O13_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RDS_O13_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get NTE Records from REF_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I12_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I12_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESULTS_NOTES Records from REF_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTS_NOTESRecords(this REF_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS_NOTES Records from REF_I12_OBSERVATION
        /// </summary>
        public static List<REF_I12_RESULTS_NOTES> GetAllRESULTS_NOTESRecords(this REF_I12_OBSERVATION message)
        {
            return message.GetAllRecords<REF_I12_RESULTS_NOTES>("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");
        }

        /// <summary>
        /// Get CTD Records from REF_I12_PROVIDER_CONTACT
        /// </summary>
        public static IEnumerable GetCTDRecords(this REF_I12_PROVIDER_CONTACT message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from REF_I12_PROVIDER_CONTACT
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this REF_I12_PROVIDER_CONTACT message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get NTE Records from REF_I12_RESULTS_NOTES
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I12_RESULTS_NOTES message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I12_RESULTS_NOTES
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I12_RESULTS_NOTES message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RER_RER_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RER_RER_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RER_RER_DEFINITION
        /// </summary>
        public static List<RER_RER_ORDER> GetAllORDERRecords(this RER_RER_DEFINITION message)
        {
            return message.GetAllRecords<RER_RER_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from RER_RER_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RER_RER_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RER_RER_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RER_RER_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RER_RER_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RER_RER_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RER_RER_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RER_RER_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RER_RER_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RER_RER_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RER_RER_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RER_RER_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RGR_RGR_DEFINTION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RGR_RGR_DEFINTION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RGR_RGR_DEFINTION
        /// </summary>
        public static List<RGR_RGR_ORDER> GetAllORDERRecords(this RGR_RGR_DEFINTION message)
        {
            return message.GetAllRecords<RGR_RGR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from RGR_RGR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGR_RGR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGR_RGR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGR_RGR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RGR_RGR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGR_RGR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGR_RGR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGR_RGR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get RXG Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXGRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXGRepetitionsUsed", "GetRXG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXG Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXG> GetAllRXGRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXG>("RXGRepetitionsUsed", "GetRXG");
        }

        /// <summary>
        /// Get RXR Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RGR_RGR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGR_RGR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGR_RGR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGR_RGR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXC Records from RGV_O15_COMPONENTS
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O15_COMPONENTS message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O15_COMPONENTS
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O15_COMPONENTS message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_COMPONENTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_COMPONENTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_COMPONENTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_COMPONENTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RGV_O15_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O15_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O15_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O15_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RGV_O15_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O15_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O15_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O15_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get RXR Records from RGV_O15_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O15_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O15_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O15_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RGV_O15_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O15_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O15_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O15_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get OBSERVATION Records from RGV_O15_GIVE
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RGV_O15_GIVE message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RGV_O15_GIVE
        /// </summary>
        public static List<RGV_O15_OBSERVATION> GetAllOBSERVATIONRecords(this RGV_O15_GIVE message)
        {
            return message.GetAllRecords<RGV_O15_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get GIVE Records from RGV_O15_ORDER
        /// </summary>
        public static IEnumerable GetGIVERecords(this RGV_O15_ORDER message)
        {
            object[] result = message.GetRecords("GIVERepetitionsUsed", "GetGIVE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GIVE Records from RGV_O15_ORDER
        /// </summary>
        public static List<RGV_O15_GIVE> GetAllGIVERecords(this RGV_O15_ORDER message)
        {
            return message.GetAllRecords<RGV_O15_GIVE>("GIVERepetitionsUsed", "GetGIVE");
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O15_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O15_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get NTE Records from RGV_O15_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O15_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O15_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O15_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get AL1 Records from RGV_O15_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RGV_O15_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RGV_O15_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RGV_O15_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get ORDER Records from ROR_ROR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this ROR_ROR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ROR_ROR_DEFINITION
        /// </summary>
        public static List<ROR_ROR_ORDER> GetAllORDERRecords(this ROR_ROR_DEFINITION message)
        {
            return message.GetAllRecords<ROR_ROR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from ROR_ROR_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this ROR_ROR_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from ROR_ROR_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this ROR_ROR_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from ROR_ROR_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this ROR_ROR_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from ROR_ROR_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this ROR_ROR_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from ROR_ROR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ROR_ROR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ROR_ROR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ROR_ROR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from RPA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RPA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPA_I08_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESULTS Records from RPA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RPA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RPA_I08_OBSERVATION
        /// </summary>
        public static List<RPA_I08_RESULTS> GetAllRESULTSRecords(this RPA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<RPA_I08_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Get CTD Records from RPA_I08_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPA_I08_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPA_I08_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPA_I08_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get NTE Records from RPA_I08_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RPA_I08_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPA_I08_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPA_I08_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get GT1 Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get INSURANCE Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RPI_I01_INSURANCE> GetAllINSURANCERecords(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RPI_I01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get CTD Records from RPI_I01_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPI_I01_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPI_I01_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPI_I01_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get GT1 Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get INSURANCE Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RPI_I04_INSURANCE> GetAllINSURANCERecords(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RPI_I04_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get CTD Records from RPI_I04_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPI_I04_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPI_I04_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPI_I04_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get CTD Records from RPL_I02_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPL_I02_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPL_I02_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPL_I02_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get CTD Records from RPR_I03_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPR_I03_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPR_I03_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPR_I03_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get GT1 Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get INSURANCE Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQA_I08_INSURANCE> GetAllINSURANCERecords(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQA_I08_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get NTE Records from RQA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I08_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESULTS Records from RQA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RQA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RQA_I08_OBSERVATION
        /// </summary>
        public static List<RQA_I08_RESULTS> GetAllRESULTSRecords(this RQA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<RQA_I08_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Get CTD Records from RQA_I08_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQA_I08_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQA_I08_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQA_I08_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get NTE Records from RQA_I08_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I08_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I08_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I08_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get CTD Records from RQC_I05_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQC_I05_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQC_I05_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQC_I05_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get GT1 Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Get INSURANCE Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQI_I01_INSURANCE> GetAllINSURANCERecords(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQI_I01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Get CTD Records from RQI_I01_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQI_I01_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQI_I01_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQI_I01_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get CTD Records from RQP_I04_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQP_I04_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQP_I04_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQP_I04_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get RXA Records from RRA_O18_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXARecords(this RRA_O18_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RRA_O18_ADMINISTRATION
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RRA_O18_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Get NTE Records from RRA_O18_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRA_O18_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRA_O18_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRA_O18_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RRA_O18_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRA_O18_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRA_O18_RESPONSE
        /// </summary>
        public static List<RRA_O18_ORDER> GetAllORDERRecords(this RRA_O18_RESPONSE message)
        {
            return message.GetAllRecords<RRA_O18_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from RRD_O14_DISPENSE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRD_O14_DISPENSE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRD_O14_DISPENSE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRD_O14_DISPENSE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RRD_O14_DISPENSE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRD_O14_DISPENSE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRD_O14_DISPENSE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRD_O14_DISPENSE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RRD_O14_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRD_O14_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRD_O14_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRD_O14_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RRD_O14_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRD_O14_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRD_O14_RESPONSE
        /// </summary>
        public static List<RRD_O14_ORDER> GetAllORDERRecords(this RRD_O14_RESPONSE message)
        {
            return message.GetAllRecords<RRD_O14_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from RRE_O12_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRE_O12_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRE_O12_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRE_O12_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RRE_O12_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRE_O12_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRE_O12_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRE_O12_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RRE_O12_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRE_O12_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRE_O12_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRE_O12_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RRE_O12_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRE_O12_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRE_O12_RESPONSE
        /// </summary>
        public static List<RRE_O12_ORDER> GetAllORDERRecords(this RRE_O12_RESPONSE message)
        {
            return message.GetAllRecords<RRE_O12_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get RXR Records from RRG_O16_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRG_O16_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRG_O16_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRG_O16_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RRG_O16_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRG_O16_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRG_O16_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRG_O16_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RRG_O16_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRG_O16_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRG_O16_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRG_O16_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get ORDER Records from RRG_O16_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRG_O16_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRG_O16_RESPONSE
        /// </summary>
        public static List<RRG_O16_ORDER> GetAllORDERRecords(this RRG_O16_RESPONSE message)
        {
            return message.GetAllRecords<RRG_O16_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Get NTE Records from RRI_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I12_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I12_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESULTS_NOTES Records from RRI_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTS_NOTESRecords(this RRI_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS_NOTES Records from RRI_I12_OBSERVATION
        /// </summary>
        public static List<RRI_I12_RESULTS_NOTES> GetAllRESULTS_NOTESRecords(this RRI_I12_OBSERVATION message)
        {
            return message.GetAllRecords<RRI_I12_RESULTS_NOTES>("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");
        }

        /// <summary>
        /// Get CTD Records from RRI_I12_PROVIDER_CONTACT
        /// </summary>
        public static IEnumerable GetCTDRecords(this RRI_I12_PROVIDER_CONTACT message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RRI_I12_PROVIDER_CONTACT
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RRI_I12_PROVIDER_CONTACT message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Get NTE Records from RRI_I12_RESULTS_NOTES
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I12_RESULTS_NOTES message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I12_RESULTS_NOTES
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I12_RESULTS_NOTES message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RDT Records from RSP_K13_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this RSP_K13_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from RSP_K13_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this RSP_K13_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Get ORG Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetORGRecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("ORGRepetitionsUsed", "GetORG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORG Records from RSP_K25_STAFF
        /// </summary>
        public static List<ORG> GetAllORGRecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<ORG>("ORGRepetitionsUsed", "GetORG");
        }

        /// <summary>
        /// Get AFF Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetAFFRecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("AFFRepetitionsUsed", "GetAFF");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AFF Records from RSP_K25_STAFF
        /// </summary>
        public static List<AFF> GetAllAFFRecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<AFF>("AFFRepetitionsUsed", "GetAFF");
        }

        /// <summary>
        /// Get LAN Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetLANRecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("LANRepetitionsUsed", "GetLAN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LAN Records from RSP_K25_STAFF
        /// </summary>
        public static List<LAN> GetAllLANRecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<LAN>("LANRepetitionsUsed", "GetLAN");
        }

        /// <summary>
        /// Get EDU Records from RSP_K25_STAFF
        /// </summary>
        public static IEnumerable GetEDURecords(this RSP_K25_STAFF message)
        {
            object[] result = message.GetRecords("EDURepetitionsUsed", "GetEDU");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all EDU Records from RSP_K25_STAFF
        /// </summary>
        public static List<EDU> GetAllEDURecords(this RSP_K25_STAFF message)
        {
            return message.GetAllRecords<EDU>("EDURepetitionsUsed", "GetEDU");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z82_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z82_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z82_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z82_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z82_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z82_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z82_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z82_ENCODED_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z82_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z82_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z82_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z82_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_QUERY_RESPONSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z82_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z82_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z82_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z82_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z82_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z82_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z82_TREATMENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z82_TREATMENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z82_TREATMENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z82_TREATMENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z82_TREATMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z82_TREATMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z82_TREATMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z82_TREATMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get AL1 Records from RSP_Z82_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this RSP_Z82_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RSP_Z82_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RSP_Z82_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_ADMINISTRATION
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z86_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z86_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z86_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z86_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z86_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z86_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_DISPENSE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_DISPENSE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_DISPENSE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_DISPENSE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_DISPENSE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_DISPENSE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_DISPENSE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_DISPENSE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_ENCODED_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_ENCODED_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z86_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z86_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z86_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z86_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z86_ORDER_DETAIL
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z86_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z86_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z86_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get AL1 Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetAL1Records(this RSP_Z86_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RSP_Z86_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z86_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z86_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z86_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z86_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z86_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Get AL1 Records from RSP_Z88_ALLERGY
        /// </summary>
        public static IEnumerable GetAL1Records(this RSP_Z88_ALLERGY message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RSP_Z88_ALLERGY
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RSP_Z88_ALLERGY message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z88_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z88_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z88_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z88_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z88_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z88_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z88_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z88_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z88_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z88_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z88_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z88_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z88_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z88_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXR Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static IEnumerable GetRXRRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Get RXC Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static IEnumerable GetRXCRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RSP_Z88_ORDER_ENCODED
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RSP_Z88_ORDER_ENCODED message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z88_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z88_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z88_QUERY_RESPONSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z88_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z88_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z88_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z88_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z88_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z88_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z88_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z90_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z90_COMMON_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RSP_Z90_COMMON_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RSP_Z90_COMMON_ORDER
        /// </summary>
        public static List<RSP_Z90_OBSERVATION> GetAllOBSERVATIONRecords(this RSP_Z90_COMMON_ORDER message)
        {
            return message.GetAllRecords<RSP_Z90_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z90_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z90_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z90_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z90_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NK1 Records from RSP_Z90_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this RSP_Z90_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from RSP_Z90_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this RSP_Z90_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Get NTE Records from RSP_Z90_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RSP_Z90_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RSP_Z90_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RSP_Z90_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get COMMON_ORDER Records from RSP_Z90_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetCOMMON_ORDERRecords(this RSP_Z90_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all COMMON_ORDER Records from RSP_Z90_QUERY_RESPONSE
        /// </summary>
        public static List<RSP_Z90_COMMON_ORDER> GetAllCOMMON_ORDERRecords(this RSP_Z90_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<RSP_Z90_COMMON_ORDER>("COMMON_ORDERRepetitionsUsed", "GetCOMMON_ORDER");
        }

        /// <summary>
        /// Get RDT Records from RTB_K13_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this RTB_K13_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from RTB_K13_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this RTB_K13_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Get RDT Records from RTB_Q13_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this RTB_Q13_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from RTB_Q13_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this RTB_Q13_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Get RDT Records from RTB_Z74_ROW_DEFINITION
        /// </summary>
        public static IEnumerable GetRDTRecords(this RTB_Z74_ROW_DEFINITION message)
        {
            object[] result = message.GetRecords("RDTRepetitionsUsed", "GetRDT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RDT Records from RTB_Z74_ROW_DEFINITION
        /// </summary>
        public static List<RDT> GetAllRDTRecords(this RTB_Z74_ROW_DEFINITION message)
        {
            return message.GetAllRecords<RDT>("RDTRepetitionsUsed", "GetRDT");
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBX Records from SIU_S12_PATIENT
        /// </summary>
        public static IEnumerable GetOBXRecords(this SIU_S12_PATIENT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SIU_S12_PATIENT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SIU_S12_PATIENT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get DG1 Records from SIU_S12_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SIU_S12_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SIU_S12_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SIU_S12_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SERVICE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_SERVICE> GetAllSERVICERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESOURCES Records from SQM_S25_REQUEST
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SQM_S25_REQUEST message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SQM_S25_REQUEST
        /// </summary>
        public static List<SQM_S25_RESOURCES> GetAllRESOURCESRecords(this SQM_S25_REQUEST message)
        {
            return message.GetAllRecords<SQM_S25_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Get SERVICE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_SERVICE> GetAllSERVICERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SERVICE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_SERVICE> GetAllSERVICERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_SCHEDULE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_SCHEDULE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_SCHEDULE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_SCHEDULE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get RESOURCES Records from SQR_S25_SCHEDULE
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SQR_S25_SCHEDULE message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SQR_S25_SCHEDULE
        /// </summary>
        public static List<SQR_S25_RESOURCES> GetAllRESOURCESRecords(this SQR_S25_SCHEDULE message)
        {
            return message.GetAllRecords<SQR_S25_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBX Records from SRM_S01_PATIENT
        /// </summary>
        public static IEnumerable GetOBXRecords(this SRM_S01_PATIENT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SRM_S01_PATIENT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SRM_S01_PATIENT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Get DG1 Records from SRM_S01_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SRM_S01_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SRM_S01_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SRM_S01_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SERVICE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_SERVICE> GetAllSERVICERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get DG1 Records from SRR_S01_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SRR_S01_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SRR_S01_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SRR_S01_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get SERVICE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_SERVICE> GetAllSERVICERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get PATIENT Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<SRR_S01_PATIENT> GetAllPATIENTRecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<SRR_S01_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Get RESOURCES Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<SRR_S01_RESOURCES> GetAllRESOURCESRecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<SRR_S01_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get PRODUCT Records from SUR_P09_FACILITY
        /// </summary>
        public static IEnumerable GetPRODUCTRecords(this SUR_P09_FACILITY message)
        {
            object[] result = message.GetRecords("PRODUCTRepetitionsUsed", "GetPRODUCT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRODUCT Records from SUR_P09_FACILITY
        /// </summary>
        public static List<SUR_P09_PRODUCT> GetAllPRODUCTRecords(this SUR_P09_FACILITY message)
        {
            return message.GetAllRecords<SUR_P09_PRODUCT>("PRODUCTRepetitionsUsed", "GetPRODUCT");
        }

        /// <summary>
        /// Get FACILITY_DETAIL Records from SUR_P09_FACILITY
        /// </summary>
        public static IEnumerable GetFACILITY_DETAILRecords(this SUR_P09_FACILITY message)
        {
            object[] result = message.GetRecords("FACILITY_DETAILRepetitionsUsed", "GetFACILITY_DETAIL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FACILITY_DETAIL Records from SUR_P09_FACILITY
        /// </summary>
        public static List<SUR_P09_FACILITY_DETAIL> GetAllFACILITY_DETAILRecords(this SUR_P09_FACILITY message)
        {
            return message.GetAllRecords<SUR_P09_FACILITY_DETAIL>("FACILITY_DETAILRepetitionsUsed", "GetFACILITY_DETAIL");
        }

        /// <summary>
        /// Get NTE Records from VXR_V03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this VXR_V03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from VXR_V03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this VXR_V03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from VXR_V03_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this VXR_V03_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from VXR_V03_ORDER
        /// </summary>
        public static List<VXR_V03_OBSERVATION> GetAllOBSERVATIONRecords(this VXR_V03_ORDER message)
        {
            return message.GetAllRecords<VXR_V03_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NTE Records from VXU_V04_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this VXU_V04_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from VXU_V04_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this VXU_V04_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Get OBSERVATION Records from VXU_V04_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this VXU_V04_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from VXU_V04_ORDER
        /// </summary>
        public static List<VXU_V04_OBSERVATION> GetAllOBSERVATIONRecords(this VXU_V04_ORDER message)
        {
            return message.GetAllRecords<VXU_V04_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Get NK1 Records from VXX_V02_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this VXX_V02_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from VXX_V02_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this VXX_V02_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }
        #endregion
    }
}