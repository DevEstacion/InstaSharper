﻿using System;
using System.Collections.Generic;
using InstaSharper.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstaSharper.Converters.Json
{
    internal class InstaFeedResponseDataConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(InstaFeedResponse);
        }

        public override object ReadJson(JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            var feed = token.ToObject<InstaFeedResponse>();
            var items = token["feed_items"];
            if (items != null)
            {
                foreach (var item in items)
                {
                    var mediaOrAd = item["media_or_ad"];
                    if (mediaOrAd == null) continue;
                    var media = mediaOrAd.ToObject<InstaMediaItemResponse>();
                    feed.Items.Add(media);
                }
            }
            else
            {
                items = token["items"];
                feed.Items = items.ToObject<List<InstaMediaItemResponse>>();
            }
            var users = token["suggested_users"]?["suggestions"];
            if (users != null)
                foreach (var user in users)
                {
                    if (user == null) continue;
                    var usr = user.ToObject<InstaUserResponse>();
                    feed.SuggestedUsers.Add(usr);
                }
            return feed;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}