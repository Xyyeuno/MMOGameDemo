// Fill out your copyright notice in the Description page of Project Settings.


#include "GameAbility/XAbilitySystemComponent.h"

void UXAbilitySystemComponent::ReceiveDamage(UXAbilitySystemComponent* SourceASC, float UnmitigatedDamage, float MitigatedDamage)
{
	ReceivedDamage.Broadcast(SourceASC, UnmitigatedDamage, MitigatedDamage);
}
