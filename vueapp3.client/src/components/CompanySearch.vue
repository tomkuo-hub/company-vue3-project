<template>
  <div>
    <h2>公司搜索</h2>
    <input v-model="companyCode" placeholder="輸入公司代號" @keyup.enter="searchCompanies">
    <button @click="searchCompanies">搜索</button>

    <table v-if="companies.length">
      <thead>
        <tr>
          <th>公司代號</th>
          <th>公司名稱</th>
          <!-- 添加其他需要顯示的欄位 -->
        </tr>
      </thead>
      <tbody>
        <tr v-for="company in companies" :key="company.companyCode">
          <td>{{ company.companyCode }}</td>
          <td>{{ company.companyName }}</td>
          <!-- 添加其他需要顯示的欄位 -->
        </tr>
      </tbody>
    </table>
    <p v-else>沒有找到匹配的公司</p>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'CompanySearch',
  data() {
    return {
      companyCode: '',
      companies: []
    }
  },
  methods: {
    async searchCompanies() {
      try {
        const response = await axios.get('/company', {
          params: {
            companyCode: this.companyCode
          }
        });
        this.companies = response.data;
      } catch (error) {
        console.error('Error fetching companies:', error);
      }
    }
  },
  mounted() {
    this.searchCompanies(); // 初始加載所有公司
  }
}
</script>

<style scoped>
/* 添加您的樣式 */
</style>

