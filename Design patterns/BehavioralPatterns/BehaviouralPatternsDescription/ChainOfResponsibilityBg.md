# Chain of Responsibility

Веригата от отговорности се отнася до колекция от обекти, имплементиращи еднакъв базов клас,
които отговарят и са компетенти за обработката на различна част от работата.

Когато някаква единица работа бъде изискана от веригата, то тази работа ще бъде подавана по веригата
докато не бъде намерена компетента имплементация. 

Консумиращият клас/ метод не знае коя конкретна имплементация ще изпълни работата, а е отговорност 
на веригата да намери подходяща такава.

[Diagram](http://www.dofactory.com/net/chain-of-responsibility-design-pattern)