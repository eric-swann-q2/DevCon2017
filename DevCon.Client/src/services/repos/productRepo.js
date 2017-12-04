import apiHelper from '../apiHelper'

export class ProductRepo {
  
  getProducts(tenantId) {
    debugger
    return apiHelper.get('products')
  }

  // async getCustomForm(tenantId, customFormId) {
  //   const result = await apiHelper.get(`management/financialinstitutions/${tenantId}/dynamicforms/${customFormId}`)
  //   return {
  //     data: {
  //       id: result.data.dynamicFormId,
  //       name: result.data.name,
  //       title: result.data.title,
  //       description: result.data.description,
  //       formData: result.data.formData
  //     }
  //   }
  // }

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
