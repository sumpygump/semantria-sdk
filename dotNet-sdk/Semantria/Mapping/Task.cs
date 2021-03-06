﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Semantria.Com.Mapping
{
    [DataContract(Name = "document")]
    [XmlRootAttribute("document", Namespace = "")]
    public class Document
    {
        [DataMember(Name = "id")]
        [XmlElementAttribute("id")]
        public string Id { get; set; }

        [DataMember(Name = "text")]
        [XmlElementAttribute("text")]
        public string Text { get; set; }
    }

    [DataContract(Name = "collection")]
    [XmlRootAttribute("collection", Namespace = "")]
    public class Collection
    {
        [DataMember(Name = "id")]
        [XmlElementAttribute("id")]
        public string Id { get; set; }

        [DataMember(Name = "documents", EmitDefaultValue = false)]
        [XmlArrayAttribute("documents")]
        [XmlArrayItemAttribute("document", typeof(string))]
        public List<string> Documents { get; set; }
    }
}

namespace Semantria.Com.Mapping.Stub
{
    [DataContract(Name = "documents")]
    [XmlRootAttribute("documents", Namespace = "")]
    public class Documents
    {
        [DataMember(Name = "document")]
        [XmlElementAttribute("document")]
        public List<Document> Data { get; set; }
    }

    [DataContract(Name = "collections")]
    [XmlRootAttribute("collections", Namespace = "")]
    public class Collections
    {
        [DataMember(Name = "collection")]
        [XmlElementAttribute("collection")]
        public List<Collection> Data { get; set; }
    }
}
