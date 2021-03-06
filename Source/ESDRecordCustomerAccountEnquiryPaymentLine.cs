﻿/// <remarks>
/// Copyright (C) 2018 Squizz PTY LTD
/// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.  If not, see http://www.gnu.org/licenses/.
/// </remarks>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standard Record holding data for a customer account enquiry payment line</summary>
    [DataContract]
    public class ESDRecordCustomerAccountEnquiryPaymentLine
    {
        /// <summary>Key that allows the customer account payment line record to be uniquely identified and linked to.</summary>
        [DataMember]
        public string keyPaymentLineID { get; set; }
        /// <summary>ID that allows the line to be identified with. May or may not be unique.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string lineItemID { get; set; }
        /// <summary>Code that allows the line to be identified with. May or may not be unique.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string lineItemCode { get; set; }
        /// <summary>Defines the type of data that the line represents. Set it to one of the constants prefixed with RECORD_LINE_TYPE_ in the ESDocumentCustomerAccountEnquiry class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string lineType { get; set; }
        /// <summary>text to describe any details of the line.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }
        /// <summary>Language that all text is described in. Set it to one of the LANG constants in the ESDocumentConstants class</summary>
        [DataMember(EmitDefaultValue = false)]
        public string language { get; set; }
        /// <summary>ISO currency code that denotes the currency that all monetary amounts stored as in the line</summary>
        [DataMember(EmitDefaultValue = false)]
        public string currencyCode { get; set; }
        /// <summary>Monetary amount that the payment line applies to</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal amount { get; set; }
        /// <summary>Key of an entity that is linked to the payment as a reference. A Reference could be a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceKeyID { get; set; }
        /// <summary>Type of entity that is linked to the payment as a reference.  A Reference could be a record such as a sales order or invoice</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceType { get; set; }
        /// <summary>Number that provides a reference to the payment.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string referenceNumber { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
