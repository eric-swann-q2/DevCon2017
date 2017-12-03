<template>
  <q-field :error="$v.dateValue.$error" :error-label="dateValueError">
    <q-input :float-label="label" maxLength="10" v-model="dateValue" @change="$v.dateValue.$touch()" @blur="$v.dateValue.$touch()" />
  </q-field>
</template>

<script>
import moment from 'moment'
import { validationMixin } from 'vuelidate'
import { required } from 'vuelidate/lib/validators'

export default {
  name: 'date-editor',
  mixins: [validationMixin],
  validations: {
    dateValue: {
      required,
      isDate(value) {
        if (!value) return false
        return moment.utc(value, this.format, true).isValid()
      },
      minDate(value) {
        if (!value || !this.minValue || this.minValue === '') return true
        const momentVal = this.createMoment(value)
        if (!momentVal.isValid()) return true
        return momentVal.isSameOrAfter(this.createMoment(this.minValue))
      },
      maxDate(value) {
        if (!value || !this.maxValue || this.maxValue === '') return true
        const momentVal = this.createMoment(value)
        if (!momentVal.isValid()) return true
        return momentVal.isSameOrBefore(moment.utc(this.maxValue))
      }
    }
  },
  data() {
    return {
      dateValue: null
    }
  },
  props: {
    format: {
      default: 'M/D/YYYY',
      type: String
    },
    value: {},
    label: {
      default: 'Date value',
      type: String
    },
    errorLabel: {
      default: 'Value',
      type: String
    },
    minValue: {
      default: () => '01/01/1900',
      type: String
    },
    maxValue: {
      default: () => moment.utc().format(),
      type: String
    }
  },
  watch: {
    dateValue(newValue) {
      if (!this.$v.$invalid) {
        var newMoment = this.createMoment(newValue)
        if (newMoment.isValid()) {
          this.$emit('input', newMoment.format())
          return
        }
      }
      this.$emit('input', newValue)
    },
    value(newValue) {
      if (!newValue) return null
      let valMoment = moment.utc(newValue, moment.ISO_8601, true)
      if (!valMoment.isValid()) {
        valMoment = this.createMoment(newValue)
      }
      if (valMoment.isValid()) {
        this.dateValue = valMoment.format(this.format)
      }
    }
  },
  methods: {
    createMoment(value) {
      return moment.utc(value, this.format, true)
    }
  },
  computed: {
    dateValueError() {
      if (!this.$v.dateValue.$dirty) return
      if (!this.$v.dateValue.required) return `${this.errorLabel} is required`
      if (!this.$v.dateValue.isDate) return `${this.errorLabel} is not a valid date`
      if (!this.$v.dateValue.minDate) return `${this.errorLabel} is less than the min date`
      if (!this.$v.dateValue.maxDate) return `${this.errorLabel} is greater than the max date`
    }
  }
}
</script>


