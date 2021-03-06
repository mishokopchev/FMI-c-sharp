﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using aspdota.Commons;

namespace aspdota.XmlDto
{
    [XmlRoot(ElementName = "hero")]
    [XmlType("hero")]
    public class Hero
    {
        [XmlAttribute(AttributeName = "id")]
        public string ID { get; set; } 
        [XmlAttributeAttribute(AttributeName = "attack")]
        public Attack Attack { get; set; } // range/melee
        [XmlAttributeAttribute(AttributeName = "affiliation")]
        public Affiliation Affiliation { get; set; } // sentinel|scorge
        [XmlElement(ElementName = "title")]
        public String Title { get; set; }
        [XmlElement(ElementName = "atribute")]
        public AttributeHero Short { get; set; }
        [XmlElement(ElementName = "status")]
        public String Status { get; set; }
        [XmlElement(ElementName = "movespeed")]
        public int Movespeed { get; set; }
        [XmlArray(ElementName = "skills")]
        public List<Skill> Skills { get; set; } = new List<Skill>();
        [XmlElement(ElementName = "armor")]
        public String Armor { get; set; }
        [XmlElement(ElementName = "dps")]
        public int DPS { get; set; }

        public Hero()
        {
        }
    }



}
