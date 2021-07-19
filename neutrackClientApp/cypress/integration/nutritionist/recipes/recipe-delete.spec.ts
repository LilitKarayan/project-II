import { RecipeHelper } from '../../../helper/recipeHelper';
import { Helper } from '../../../helper/helper';

describe('successful scenario tests - delete recipe', () => {
  const helper = new Helper();
  const recipeHelper = new RecipeHelper();

  it('should have button to delete recipe - Pepperoni pizza', () => {
    helper.signInStartDashboard();
    recipeHelper.directToRecipe();

    cy.get('mat-accordion mat-expansion-panel:last')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last button:last').should(
          'exist'
        );
      });
  });

  it('should have confirmation box appear', () => {
    helper.signInStartDashboard();
    recipeHelper.directToRecipe();

    cy.get('mat-accordion mat-expansion-panel:last')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last button:last').click();
      });

    cy.contains('Confirm action');
  });

  it('should not delete recipe', () => {
    helper.signInStartDashboard();
    recipeHelper.directToRecipe();

    cy.get('mat-accordion mat-expansion-panel:last')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last button:last').click();
      });

    cy.get('#deleteNoButton')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last').contains(
          'Pizza Pinapple'
        );
      });
  });

  it('should delete recipe', () => {
    helper.signInStartDashboard();
    recipeHelper.directToRecipe();

    cy.get('mat-accordion mat-expansion-panel:last')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last button:last').click();
      });

    cy.get('#deleteYesButton')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last').should(
          'not.contain',
          'Pizza Pinapple'
        );
      });
  });

  it('should delete recipe product', () => {
    helper.signInStartDashboard();
    recipeHelper.directToRecipe();

    cy.get('mat-accordion mat-expansion-panel:last')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last button:first').click();
      });

    cy.get('#theRecipeProducts button:first')
      .should('exist')
      .then(() => {
        cy.get('#theRecipeProducts button:first').click();
      });

    cy.get('#theRecipeProducts').should('not.contain', 'Cornstarch');
    cy.get('#addButton').click();
    cy.wait(5000);

    cy.get('mat-accordion mat-expansion-panel:last')
      .click()
      .then(() => {
        cy.get('mat-accordion mat-expansion-panel:last').should('not.contain', 'Cornstarch');
      });
  });
});
