﻿using AvroSerializer.Abstractions;

namespace ConsoleApp16.Serializers;

//[AvroSchema(@"{
//  ""type"": ""record"",
//  ""name"": ""UserPromotionLoyaltyAssignation"",
//  ""namespace"": ""eu.scrm.dp.schemas"",
//  ""fields"": [
//    {
//      ""name"": ""EventId"",
//      ""type"": {
//        ""logicalType"": ""uuid"",
//        ""type"": ""string""
//      }
//    },
//    {
//      ""name"": ""EventTimestamp"",
//      ""type"": {
//        ""type"": ""long"",
//        ""logicalType"": ""timestamp-millis""
//      }
//    },
//    {
//      ""name"": ""ApiTimestamp"",
//      ""type"": {
//        ""type"": ""long"",
//        ""logicalType"": ""timestamp-millis""
//      }
//    },
//    {
//      ""name"": ""UserPromotionId"",
//      ""type"": {
//        ""logicalType"": ""uuid"",
//        ""type"": ""string""
//      }
//    },
//    {
//      ""name"": ""ClientId"",
//      ""type"": {
//        ""type"": ""string""
//      }
//    },
//    {
//      ""name"": ""PromotionId"",
//      ""type"": {
//        ""logicalType"": ""uuid"",
//        ""type"": ""string""
//      }
//    },
//    {
//      ""name"": ""InternalPromotionId"",
//      ""type"": {
//        ""type"": ""string""
//      }
//    },
//    {
//      ""name"": ""AssignationMethod"",
//      ""type"": {
//        ""type"": ""string""
//      }
//    },
//    {
//      ""name"": ""StartDisplayDateTime"",
//      ""type"": {
//        ""type"": ""long"",
//        ""logicalType"": ""timestamp-millis""
//      }
//    },
//    {
//      ""name"": ""StartValidityDateTime"",
//      ""type"": {
//        ""type"": ""long"",
//        ""logicalType"": ""timestamp-millis""
//      }
//    },
//    {
//      ""name"": ""EndValidityDateTime"",
//      ""type"": {
//        ""type"": ""long"",
//        ""logicalType"": ""timestamp-millis""
//      }
//    },
//    {
//      ""name"": ""PersonalDiscount"",
//      ""type"": [
//        ""null"",
//        ""double""
//      ],
//      ""default"": null
//    },
//    {
//      ""name"": ""External"",
//      ""type"": {
//        ""type"": ""record"",
//        ""name"": ""External"",
//        ""namespace"": ""eu.scrm.dp.schemas.UserPromotionLoyaltyAssignation"",
//        ""fields"": [
//          {
//            ""name"": ""CampaignId"",
//            ""type"": [
//              ""null"",
//              ""string""
//            ],
//            ""default"": null
//          },
//          {
//            ""name"": ""AppName"",
//            ""type"": {
//              ""type"": ""string""
//            }
//          }
//        ]
//      }
//    }
//  ]
//}")]
[AvroSchema("{\"type\": \"boolean\"}")]
public partial class BooleanSerializer : AvroSerializer<bool>
{
}