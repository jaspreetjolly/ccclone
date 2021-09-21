// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

import { TFunction } from "i18next";

export const getInitAdaptiveCard = (t: TFunction) => {
    const titleTextAsString = t("TitleText");
    return (
        {
            "type": "AdaptiveCard",
            "body": [
                {
                    "type": "TextBlock",
                    "weight": "Bolder",
                    "text": titleTextAsString,
                    "size": "ExtraLarge",
                    "wrap": true,
                    "fontType":"Arial",
                },
                {
                    "type": "TextBlock",
                    "size": "Large",
                    "wrap": true,
                    "text": "",
                    "fontType": "Arial",
                },
                {
                    "type": "Image",
                    "spacing": "Default",
                    "url": "",
                    "size": "Stretch",
                    "width": "400px",
                    "altText": ""
                },
                {
                    "type": "TextBlock",
                    "text": "",
                    "wrap": true,
                    "fontType": "Arial",
                },
                {
                    "type": "TextBlock",
                    "wrap": true,
                    "size": "Small",
                    "weight": "Lighter",
                    "text": "",
                    "fontType": "Arial",
                }
            ],
            "$schema": "https://adaptivecards.io/schemas/adaptive-card.json",
            "version": "1.0"
        }
    );
}

export const getCardTitle = (card: any) => {
    return card.body[0].text;
}

export const setCardTitle = (card: any, title: string) => {
    card.body[0].text = title;
}

export const getCardSubtitle = (card: any) => {
    return card.body[1].text;
}

export const setCardSubtitle = (card: any, subtitle?: string) => {
    card.body[1].text = subtitle;
}

export const getCardImageLink = (card: any) => {
    return card.body[2].url;
}

export const setCardImageLink = (card: any, imageLink?: string) => {
    card.body[2].url = imageLink;
}

export const getCardSummary = (card: any) => {
    return card.body[3].text;
}

export const setCardSummary = (card: any, summary?: string) => {
    card.body[3].text = summary;
}

export const getCardAuthor = (card: any) => {
    return card.body[4].text;
}

export const setCardAuthor = (card: any, author?: string) => {
    card.body[4].text = author;
}

export const getCardBtnTitle = (card: any) => {
    return card.actions[0].title;
}

export const getCardBtnLink = (card: any) => {
    return card.actions[0].url;
}

export const setCardBtn = (card: any, buttonTitle?: string, buttonLink?: string) => {
    if (buttonTitle && buttonLink) {
        card.actions = [
            {
                "type": "Action.OpenUrl",
                "title": buttonTitle,
                "url": buttonLink
            }
        ];
    } else {
        delete card.actions;
    }
}
