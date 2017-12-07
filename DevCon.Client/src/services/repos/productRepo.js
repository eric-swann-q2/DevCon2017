import apiHelper from '../apiHelper'

export class ProductRepo {
  
  retrieveProducts(tenantId) {
    return apiHelper.get('query/products')
  }

  // postCustomForm(tenantId, customForm) {
  //   const formData = JSON.stringify(customForm.formData)
  //   return apiHelper.post(`management/financialinstitutions/${tenantId}/dynamicforms`, {
  //     name: customForm.name,
  //     title: customForm.title,
  //     description: customForm.description,
  //     formData: formData
  //   })
  // }

  // putCustomForm(tenantId, customForm) {
  //   const formData = JSON.stringify(customForm.formData)
  //   return apiHelper.put(`management/financialinstitutions/${tenantId}/dynamicforms/${customForm.customFormId}`, {
  //     name: customForm.name,
  //     title: customForm.title,
  //     description: customForm.description,
  //     formData: formData
  //   })
  // }
}

const _productRepo = new ProductRepo()

export default _productRepo
