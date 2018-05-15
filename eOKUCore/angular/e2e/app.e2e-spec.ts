import { eOKUCoreTemplatePage } from './app.po';

describe('eOKUCore App', function() {
  let page: eOKUCoreTemplatePage;

  beforeEach(() => {
    page = new eOKUCoreTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
