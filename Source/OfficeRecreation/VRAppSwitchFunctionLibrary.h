#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
/* #include "predefs.h" */

#include "VRAppSwitchFunctionLibrary.generated.h"

UCLASS()
class OFFICE_RECREATION_API UVRAppSwitchFunctionLibrary : public UBlueprintFunctionLibrary {
  GENERATED_BODY()

  UFUNCTION(BlueprintCallable, Category = "UVRAppSwitchFunctionLibrary")
  static void markNextProgramName(FString name);

  UFUNCTION(BlueprintCallable, Category = "UVRAppSwitchFunctionLibrary")
  static void exit();
};
