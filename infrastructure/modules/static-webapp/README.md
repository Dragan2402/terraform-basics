# Static Webapp Module

This Terraform module deploys a static web application to cloud storage with CDN capabilities. It's designed to be reusable and configurable for different static web application deployments.

## Features

- Static website hosting
- CDN integration for improved performance
- Custom domain support
- SSL/TLS certificate management
- Basic security configurations

## Usage

```hcl
module "static_webapp" {
  source = "./modules/static-webapp"

  project_name     = "my-webapp"
  environment      = "production"
  location         = "eastus"
  custom_domain    = "www.example.com"
  enable_ssl       = true
  storage_account_tier = "Standard"
}
```

## Inputs

| Name                 | Description                            | Type     | Default      | Required |
| -------------------- | -------------------------------------- | -------- | ------------ | :------: |
| project_name         | Name of the project                    | `string` | n/a          |   yes    |
| environment          | Environment (e.g., dev, staging, prod) | `string` | n/a          |   yes    |
| location             | Azure region for deployment            | `string` | n/a          |   yes    |
| custom_domain        | Custom domain name for the webapp      | `string` | `null`       |    no    |
| enable_ssl           | Whether to enable SSL/TLS              | `bool`   | `true`       |    no    |
| storage_account_tier | Storage account tier                   | `string` | `"Standard"` |    no    |

## Outputs

| Name                 | Description                     |
| -------------------- | ------------------------------- |
| website_url          | The URL of the static website   |
| cdn_endpoint         | The CDN endpoint URL            |
| storage_account_name | The name of the storage account |

## Example

```hcl
module "static_webapp" {
  source = "./modules/static-webapp"

  project_name     = "my-company-website"
  environment      = "production"
  location         = "eastus"
  custom_domain    = "www.mycompany.com"
  enable_ssl       = true
  storage_account_tier = "Standard"
}

output "website_url" {
  value = module.static_webapp.website_url
}
```

## Security Considerations

- The module enables HTTPS by default
- Storage accounts are configured with appropriate security settings
- CDN is configured with security headers
- Access is restricted to HTTPS only

## Dependencies

- Azure Provider
- Azure Storage Account
- Azure CDN Profile
- Azure CDN Endpoint

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License

MIT License

Copyright (c) 2024

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
