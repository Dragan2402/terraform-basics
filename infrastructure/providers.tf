# Configure the Azure provider
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 4.28.0"
    }
  }

  required_version = ">= 1.10.0"
}

provider "azurerm" {
  features {}
  subscription_id = "43a78639-5c1d-4339-bc5d-b414642e1f5a"
}
